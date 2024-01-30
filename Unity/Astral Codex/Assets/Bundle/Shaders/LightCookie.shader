// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2104,x:34800,y:32672,varname:node_2104,prsc:2|alpha-7008-OUT;n:type:ShaderForge.SFN_Tex2d,id:5048,x:33164,y:33061,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_5048,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7411097cd1a5fec4cb72664c3eb52998,ntxv:0,isnm:False|UVIN-9620-OUT;n:type:ShaderForge.SFN_TexCoord,id:3846,x:31068,y:33105,varname:node_3846,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Subtract,id:3419,x:31302,y:33189,varname:node_3419,prsc:2|A-3846-UVOUT,B-6199-OUT;n:type:ShaderForge.SFN_Vector1,id:6199,x:31068,y:33269,varname:node_6199,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Length,id:1831,x:31511,y:32734,varname:node_1831,prsc:2|IN-3419-OUT;n:type:ShaderForge.SFN_Smoothstep,id:3930,x:32039,y:32409,varname:node_3930,prsc:2|A-7278-OUT,B-7226-OUT,V-1831-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7226,x:31578,y:32376,ptovrint:False,ptlb:EdgeFadeDistance,ptin:_EdgeFadeDistance,varname:node_7226,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.45;n:type:ShaderForge.SFN_ValueProperty,id:4749,x:31562,y:32276,ptovrint:False,ptlb:EdgeFadeSoftness,ptin:_EdgeFadeSoftness,varname:node_4749,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.25;n:type:ShaderForge.SFN_Subtract,id:7278,x:31766,y:32256,varname:node_7278,prsc:2|A-7226-OUT,B-4749-OUT;n:type:ShaderForge.SFN_Multiply,id:7008,x:34492,y:32883,varname:node_7008,prsc:2|A-3187-OUT,B-4854-OUT;n:type:ShaderForge.SFN_OneMinus,id:3187,x:32266,y:32409,varname:node_3187,prsc:2|IN-3930-OUT;n:type:ShaderForge.SFN_Power,id:5834,x:33701,y:32939,varname:node_5834,prsc:2|VAL-5048-R,EXP-8593-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8593,x:33466,y:33105,ptovrint:False,ptlb:Contrast,ptin:_Contrast,varname:node_8593,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.2;n:type:ShaderForge.SFN_Power,id:2244,x:31761,y:32966,varname:node_2244,prsc:2|VAL-1831-OUT,EXP-7296-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7296,x:31545,y:33000,ptovrint:False,ptlb:RadialDistortion,ptin:_RadialDistortion,varname:node_7296,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.2;n:type:ShaderForge.SFN_Normalize,id:8867,x:31720,y:33127,varname:node_8867,prsc:2|IN-3419-OUT;n:type:ShaderForge.SFN_Multiply,id:6802,x:32044,y:33087,varname:node_6802,prsc:2|A-2244-OUT,B-8867-OUT;n:type:ShaderForge.SFN_Multiply,id:9673,x:33947,y:32939,varname:node_9673,prsc:2|A-5834-OUT,B-4033-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4033,x:33701,y:33105,ptovrint:False,ptlb:Strength,ptin:_Strength,varname:node_4033,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:251,x:31639,y:33727,ptovrint:False,ptlb:DistortionTexture,ptin:_DistortionTexture,varname:node_251,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6338747e61b383c4c925842959fd96a0,ntxv:0,isnm:False|UVIN-2836-OUT;n:type:ShaderForge.SFN_TexCoord,id:7924,x:31164,y:33627,varname:node_7924,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:2534,x:30983,y:33849,varname:node_2534,prsc:2;n:type:ShaderForge.SFN_Add,id:2836,x:31379,y:33754,varname:node_2836,prsc:2|A-7924-UVOUT,B-2608-OUT;n:type:ShaderForge.SFN_Multiply,id:2608,x:31185,y:33849,varname:node_2608,prsc:2|A-2534-T,B-1992-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1992,x:30983,y:33998,ptovrint:False,ptlb:DistortionSpeed,ptin:_DistortionSpeed,varname:node_1992,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:4831,x:32284,y:33733,varname:node_4831,prsc:2|A-3239-OUT,B-5635-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5635,x:32036,y:33951,ptovrint:False,ptlb:DistortionStrength,ptin:_DistortionStrength,varname:node_5635,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Add,id:9620,x:32670,y:33076,varname:node_9620,prsc:2|A-6802-OUT,B-4831-OUT;n:type:ShaderForge.SFN_ComponentMask,id:8893,x:31823,y:33727,varname:node_8893,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-251-RGB;n:type:ShaderForge.SFN_Subtract,id:3239,x:32088,y:33733,varname:node_3239,prsc:2|A-8893-OUT,B-4635-OUT;n:type:ShaderForge.SFN_Vector2,id:4635,x:31823,y:33877,varname:node_4635,prsc:2,v1:0.5,v2:0.5;n:type:ShaderForge.SFN_Max,id:4854,x:34258,y:32940,varname:node_4854,prsc:2|A-9673-OUT,B-5230-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5230,x:33947,y:33105,ptovrint:False,ptlb:BaseStrength,ptin:_BaseStrength,varname:node_5230,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;proporder:5048-7226-4749-8593-7296-4033-251-1992-5635-5230;pass:END;sub:END;*/

Shader "Unlit/LightCookie" {
    Properties {
        _Texture ("Texture", 2D) = "white" {}
        _EdgeFadeDistance ("EdgeFadeDistance", Float ) = 0.45
        _EdgeFadeSoftness ("EdgeFadeSoftness", Float ) = 0.25
        _Contrast ("Contrast", Float ) = 1.2
        _RadialDistortion ("RadialDistortion", Float ) = 1.2
        _Strength ("Strength", Float ) = 1
        _DistortionTexture ("DistortionTexture", 2D) = "white" {}
        _DistortionSpeed ("DistortionSpeed", Float ) = 0
        _DistortionStrength ("DistortionStrength", Float ) = 0.5
        _BaseStrength ("BaseStrength", Float ) = 0.1
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
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform sampler2D _DistortionTexture; uniform float4 _DistortionTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _EdgeFadeDistance)
                UNITY_DEFINE_INSTANCED_PROP( float, _EdgeFadeSoftness)
                UNITY_DEFINE_INSTANCED_PROP( float, _Contrast)
                UNITY_DEFINE_INSTANCED_PROP( float, _RadialDistortion)
                UNITY_DEFINE_INSTANCED_PROP( float, _Strength)
                UNITY_DEFINE_INSTANCED_PROP( float, _DistortionSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _DistortionStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _BaseStrength)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
////// Lighting:
                float3 finalColor = 0;
                float _EdgeFadeDistance_var = UNITY_ACCESS_INSTANCED_PROP( Props, _EdgeFadeDistance );
                float _EdgeFadeSoftness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _EdgeFadeSoftness );
                float2 node_3419 = (i.uv0-0.5);
                float node_1831 = length(node_3419);
                float _RadialDistortion_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RadialDistortion );
                float4 node_2534 = _Time;
                float _DistortionSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DistortionSpeed );
                float2 node_2836 = (i.uv0+(node_2534.g*_DistortionSpeed_var));
                float4 _DistortionTexture_var = tex2D(_DistortionTexture,TRANSFORM_TEX(node_2836, _DistortionTexture));
                float _DistortionStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DistortionStrength );
                float2 node_9620 = ((pow(node_1831,_RadialDistortion_var)*normalize(node_3419))+((_DistortionTexture_var.rgb.rg-float2(0.5,0.5))*_DistortionStrength_var));
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(node_9620, _Texture));
                float _Contrast_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Contrast );
                float _Strength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Strength );
                float _BaseStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseStrength );
                fixed4 finalRGBA = fixed4(finalColor,((1.0 - smoothstep( (_EdgeFadeDistance_var-_EdgeFadeSoftness_var), _EdgeFadeDistance_var, node_1831 ))*max((pow(_Texture_var.r,_Contrast_var)*_Strength_var),_BaseStrength_var)));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
