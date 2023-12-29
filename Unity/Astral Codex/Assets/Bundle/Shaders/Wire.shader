// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9952,x:34017,y:32585,varname:node_9952,prsc:2|diff-9260-RGB,diffpow-5076-OUT,emission-1598-OUT;n:type:ShaderForge.SFN_Time,id:330,x:30489,y:32694,varname:node_330,prsc:2;n:type:ShaderForge.SFN_Fmod,id:1050,x:30880,y:32824,varname:node_1050,prsc:2|A-8718-OUT,B-23-OUT;n:type:ShaderForge.SFN_Multiply,id:8718,x:30668,y:32794,varname:node_8718,prsc:2|A-330-T,B-1231-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1231,x:30489,y:32862,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_1231,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Vector1,id:7812,x:32505,y:33036,varname:node_7812,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:9943,x:31192,y:33036,varname:node_9943,prsc:2|A-1050-OUT,B-5514-OUT;n:type:ShaderForge.SFN_Subtract,id:4601,x:31174,y:33187,varname:node_4601,prsc:2|A-1050-OUT,B-5514-OUT;n:type:ShaderForge.SFN_Vector1,id:5514,x:30910,y:33049,varname:node_5514,prsc:2,v1:1;n:type:ShaderForge.SFN_Min,id:4562,x:31953,y:32969,varname:node_4562,prsc:2|A-6538-OUT,B-5128-OUT;n:type:ShaderForge.SFN_Min,id:1892,x:32158,y:33207,varname:node_1892,prsc:2|A-4562-OUT,B-585-OUT;n:type:ShaderForge.SFN_Distance,id:5128,x:31661,y:33060,varname:node_5128,prsc:2|A-9592-OUT,B-9943-OUT;n:type:ShaderForge.SFN_Distance,id:6538,x:31613,y:32787,varname:node_6538,prsc:2|A-9592-OUT,B-1050-OUT;n:type:ShaderForge.SFN_Distance,id:585,x:31661,y:33242,varname:node_585,prsc:2|A-9592-OUT,B-4601-OUT;n:type:ShaderForge.SFN_Smoothstep,id:1951,x:32916,y:33072,varname:node_1951,prsc:2|A-3630-OUT,B-7812-OUT,V-1892-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9076,x:32505,y:32910,ptovrint:False,ptlb:StripeThickness,ptin:_StripeThickness,varname:node_9076,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Add,id:3630,x:32717,y:32935,varname:node_3630,prsc:2|A-9076-OUT,B-7812-OUT;n:type:ShaderForge.SFN_Tex2d,id:7877,x:30537,y:32303,ptovrint:False,ptlb:Pattern,ptin:_Pattern,varname:node_7877,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6e1abab6080ba064d928c358bc314d1c,ntxv:0,isnm:False|UVIN-9810-OUT;n:type:ShaderForge.SFN_TexCoord,id:128,x:29919,y:32052,varname:node_128,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Vector4Property,id:7118,x:29660,y:32123,ptovrint:False,ptlb:PatternScale,ptin:_PatternScale,varname:node_7118,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:5,v2:1,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:1637,x:29901,y:32282,varname:node_1637,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7118-XYZ;n:type:ShaderForge.SFN_Multiply,id:9810,x:30248,y:32362,varname:node_9810,prsc:2|A-128-UVOUT,B-1637-OUT;n:type:ShaderForge.SFN_Relay,id:9592,x:31167,y:32600,varname:node_9592,prsc:2|IN-7877-R;n:type:ShaderForge.SFN_Vector1,id:23,x:30668,y:32947,varname:node_23,prsc:2,v1:1;n:type:ShaderForge.SFN_Relay,id:9143,x:33088,y:32484,varname:node_9143,prsc:2|IN-7877-A;n:type:ShaderForge.SFN_Color,id:4659,x:32683,y:32742,ptovrint:False,ptlb:HighlightColor,ptin:_HighlightColor,varname:node_4659,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0.1132979,c4:1;n:type:ShaderForge.SFN_Lerp,id:3669,x:33302,y:32931,varname:node_3669,prsc:2|A-3120-OUT,B-4659-RGB,T-1951-OUT;n:type:ShaderForge.SFN_Color,id:2053,x:33313,y:32440,ptovrint:False,ptlb:EdgeColor,ptin:_EdgeColor,varname:node_2053,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:1598,x:33595,y:32709,varname:node_1598,prsc:2|A-2053-RGB,B-3669-OUT,T-9143-OUT;n:type:ShaderForge.SFN_Color,id:9260,x:33530,y:32388,ptovrint:False,ptlb:BaseColor,ptin:_BaseColor,varname:node_9260,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.4985202,c3:0.5188679,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:5076,x:33792,y:32605,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:node_5076,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:7;n:type:ShaderForge.SFN_Multiply,id:3120,x:33004,y:32668,varname:node_3120,prsc:2|A-8548-OUT,B-4659-RGB;n:type:ShaderForge.SFN_ValueProperty,id:8548,x:32683,y:32601,ptovrint:False,ptlb:BaseWireColorFactor,ptin:_BaseWireColorFactor,varname:node_8548,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.01;proporder:1231-9076-7877-7118-4659-2053-9260-5076-8548;pass:END;sub:END;*/

Shader "Custom/Wire" {
    Properties {
        _Speed ("Speed", Float ) = 0.1
        _StripeThickness ("StripeThickness", Float ) = 0.5
        _Pattern ("Pattern", 2D) = "white" {}
        _PatternScale ("PatternScale", Vector) = (5,1,0,0)
        _HighlightColor ("HighlightColor", Color) = (1,0,0.1132979,1)
        _EdgeColor ("EdgeColor", Color) = (0,0,0,1)
        _BaseColor ("BaseColor", Color) = (0,0.4985202,0.5188679,1)
        _Metallic ("Metallic", Float ) = 7
        _BaseWireColorFactor ("BaseWireColorFactor", Float ) = 0.01
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _Pattern; uniform float4 _Pattern_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Speed)
                UNITY_DEFINE_INSTANCED_PROP( float, _StripeThickness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _PatternScale)
                UNITY_DEFINE_INSTANCED_PROP( float4, _HighlightColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _EdgeColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _BaseWireColorFactor)
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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 directDiffuse = pow(max( 0.0, NdotL), _Metallic_var) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _BaseColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor );
                float3 diffuseColor = _BaseColor_var.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _EdgeColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _EdgeColor );
                float _BaseWireColorFactor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseWireColorFactor );
                float4 _HighlightColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _HighlightColor );
                float _StripeThickness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _StripeThickness );
                float node_7812 = 0.0;
                float4 _PatternScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _PatternScale );
                float2 node_9810 = (i.uv0*_PatternScale_var.rgb.rg);
                float4 _Pattern_var = tex2D(_Pattern,TRANSFORM_TEX(node_9810, _Pattern));
                float node_9592 = _Pattern_var.r;
                float4 node_330 = _Time;
                float _Speed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Speed );
                float node_1050 = fmod((node_330.g*_Speed_var),1.0);
                float node_5514 = 1.0;
                float3 emissive = lerp(_EdgeColor_var.rgb,lerp((_BaseWireColorFactor_var*_HighlightColor_var.rgb),_HighlightColor_var.rgb,smoothstep( (_StripeThickness_var+node_7812), node_7812, min(min(distance(node_9592,node_1050),distance(node_9592,(node_1050+node_5514))),distance(node_9592,(node_1050-node_5514))) )),_Pattern_var.a);
/// Final Color:
                float3 finalColor = diffuse + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _Pattern; uniform float4 _Pattern_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Speed)
                UNITY_DEFINE_INSTANCED_PROP( float, _StripeThickness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _PatternScale)
                UNITY_DEFINE_INSTANCED_PROP( float4, _HighlightColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _EdgeColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _BaseWireColorFactor)
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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 directDiffuse = pow(max( 0.0, NdotL), _Metallic_var) * attenColor;
                float4 _BaseColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor );
                float3 diffuseColor = _BaseColor_var.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
