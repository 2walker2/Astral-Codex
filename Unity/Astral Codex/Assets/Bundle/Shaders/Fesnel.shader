// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3182,x:32753,y:32627,varname:node_3182,prsc:2|emission-2889-OUT,alpha-3812-OUT;n:type:ShaderForge.SFN_Fresnel,id:2971,x:31945,y:32805,varname:node_2971,prsc:2|NRM-6416-OUT,EXP-8169-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8169,x:31664,y:32930,ptovrint:False,ptlb:FesnelExp,ptin:_FesnelExp,varname:node_8169,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_NormalVector,id:6416,x:31664,y:32744,prsc:2,pt:False;n:type:ShaderForge.SFN_Tex2d,id:4532,x:32035,y:32435,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_4532,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:3812,x:32455,y:32751,varname:node_3812,prsc:2|A-4532-A,B-1342-OUT;n:type:ShaderForge.SFN_OneMinus,id:1342,x:32192,y:32805,varname:node_1342,prsc:2|IN-2971-OUT;n:type:ShaderForge.SFN_Multiply,id:2889,x:32382,y:32453,varname:node_2889,prsc:2|A-3035-OUT,B-4532-RGB;n:type:ShaderForge.SFN_ValueProperty,id:3035,x:32189,y:32334,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_3035,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;proporder:8169-4532-3035;pass:END;sub:END;*/

Shader "Unlit/Fesnel" {
    Properties {
        _FesnelExp ("FesnelExp", Float ) = 1
        _MainTex ("MainTex", 2D) = "white" {}
        _Brightness ("Brightness", Float ) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 100
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _FesnelExp)
                UNITY_DEFINE_INSTANCED_PROP( float, _Brightness)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float _Brightness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Brightness );
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 emissive = (_Brightness_var*_MainTex_var.rgb);
                float3 finalColor = emissive;
                float _FesnelExp_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FesnelExp );
                fixed4 finalRGBA = fixed4(finalColor,(_MainTex_var.a*(1.0 - pow(1.0-max(0,dot(i.normalDir, viewDirection)),_FesnelExp_var))));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
