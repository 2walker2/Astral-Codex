// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9952,x:34891,y:32553,varname:node_9952,prsc:2|diff-9260-RGB,spec-5076-OUT,gloss-6646-OUT,emission-8545-OUT,alpha-9530-OUT;n:type:ShaderForge.SFN_Time,id:330,x:30167,y:32731,varname:node_330,prsc:2;n:type:ShaderForge.SFN_Fmod,id:1050,x:30880,y:32824,varname:node_1050,prsc:2|A-8718-OUT,B-23-OUT;n:type:ShaderForge.SFN_Multiply,id:8718,x:30346,y:32831,varname:node_8718,prsc:2|A-330-T,B-1231-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1231,x:30167,y:32899,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_1231,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Vector1,id:7812,x:32441,y:32908,varname:node_7812,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:9943,x:31192,y:33036,varname:node_9943,prsc:2|A-1050-OUT,B-5921-OUT;n:type:ShaderForge.SFN_Subtract,id:4601,x:31192,y:33180,varname:node_4601,prsc:2|A-1050-OUT,B-5921-OUT;n:type:ShaderForge.SFN_Min,id:4562,x:31953,y:32969,varname:node_4562,prsc:2|A-6538-OUT,B-5128-OUT;n:type:ShaderForge.SFN_Min,id:1892,x:32158,y:33207,varname:node_1892,prsc:2|A-4562-OUT,B-585-OUT;n:type:ShaderForge.SFN_Distance,id:5128,x:31661,y:33060,varname:node_5128,prsc:2|A-9592-OUT,B-9943-OUT;n:type:ShaderForge.SFN_Distance,id:6538,x:31657,y:32801,varname:node_6538,prsc:2|A-9592-OUT,B-1050-OUT;n:type:ShaderForge.SFN_Distance,id:585,x:31661,y:33242,varname:node_585,prsc:2|A-9592-OUT,B-4601-OUT;n:type:ShaderForge.SFN_Smoothstep,id:1951,x:32852,y:32944,varname:node_1951,prsc:2|A-3630-OUT,B-7812-OUT,V-1892-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9076,x:32441,y:32782,ptovrint:False,ptlb:StripeThickness,ptin:_StripeThickness,varname:node_9076,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Add,id:3630,x:32653,y:32807,varname:node_3630,prsc:2|A-9076-OUT,B-7812-OUT;n:type:ShaderForge.SFN_Relay,id:9592,x:31336,y:32538,varname:node_9592,prsc:2|IN-9552-OUT;n:type:ShaderForge.SFN_Vector1,id:23,x:30598,y:32911,varname:node_23,prsc:2,v1:1;n:type:ShaderForge.SFN_Color,id:4659,x:31673,y:31779,ptovrint:False,ptlb:PrimaryColor,ptin:_PrimaryColor,varname:node_4659,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.9901032,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:9260,x:34468,y:32089,ptovrint:False,ptlb:BaseColor,ptin:_BaseColor,varname:node_9260,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.4985202,c3:0.5188679,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:5076,x:34468,y:32260,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:node_5076,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:8548,x:33414,y:32449,ptovrint:False,ptlb:BaseWireOpacity,ptin:_BaseWireOpacity,varname:node_8548,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.01;n:type:ShaderForge.SFN_ValueProperty,id:6646,x:34468,y:32344,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_6646,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_TexCoord,id:9995,x:30668,y:32476,varname:node_9995,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:3802,x:30919,y:32538,varname:node_3802,prsc:2|A-9995-U,B-4922-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4922,x:30668,y:32652,ptovrint:False,ptlb:StripeCount,ptin:_StripeCount,varname:node_4922,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Fmod,id:9552,x:31115,y:32538,varname:node_9552,prsc:2|A-3802-OUT,B-8295-OUT;n:type:ShaderForge.SFN_Vector1,id:8295,x:30919,y:32690,varname:node_8295,prsc:2,v1:1;n:type:ShaderForge.SFN_Color,id:6999,x:31673,y:31961,ptovrint:False,ptlb:SecondaryColor,ptin:_SecondaryColor,varname:node_6999,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0.390867,c4:1;n:type:ShaderForge.SFN_Tex2d,id:8392,x:31367,y:32171,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_8392,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ed52176dbd204314a8bbf2cf3da84543,ntxv:0,isnm:False|UVIN-4751-OUT;n:type:ShaderForge.SFN_TexCoord,id:1630,x:30608,y:32149,varname:node_1630,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:3013,x:30508,y:31883,varname:node_3013,prsc:2;n:type:ShaderForge.SFN_Append,id:4751,x:31145,y:32171,varname:node_4751,prsc:2|A-3125-OUT,B-1630-V;n:type:ShaderForge.SFN_Multiply,id:5818,x:30722,y:31957,varname:node_5818,prsc:2|A-3013-T,B-3390-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3390,x:30508,y:32050,ptovrint:False,ptlb:NoiseSpeed,ptin:_NoiseSpeed,varname:node_3390,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Add,id:3125,x:30952,y:32078,varname:node_3125,prsc:2|A-5818-OUT,B-1630-U;n:type:ShaderForge.SFN_Lerp,id:7951,x:32081,y:32156,varname:node_7951,prsc:2|A-4659-RGB,B-6999-RGB,T-355-OUT;n:type:ShaderForge.SFN_Multiply,id:355,x:31592,y:32188,varname:node_355,prsc:2|A-8392-R,B-2186-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2186,x:31367,y:32367,ptovrint:False,ptlb:NoiseContrast,ptin:_NoiseContrast,varname:node_2186,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.2;n:type:ShaderForge.SFN_Lerp,id:6680,x:32081,y:31939,varname:node_6680,prsc:2|A-4659-A,B-6999-A,T-355-OUT;n:type:ShaderForge.SFN_OneMinus,id:4547,x:33193,y:32544,varname:node_4547,prsc:2|IN-1951-OUT;n:type:ShaderForge.SFN_Multiply,id:3005,x:33446,y:32212,varname:node_3005,prsc:2|A-6680-OUT,B-4547-OUT;n:type:ShaderForge.SFN_Max,id:5277,x:33640,y:32379,varname:node_5277,prsc:2|A-3005-OUT,B-8548-OUT;n:type:ShaderForge.SFN_Relay,id:8545,x:33590,y:31897,varname:node_8545,prsc:2|IN-7951-OUT;n:type:ShaderForge.SFN_Fresnel,id:7873,x:33640,y:32582,varname:node_7873,prsc:2|EXP-8533-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8533,x:33445,y:32632,ptovrint:False,ptlb:FresnelExponent,ptin:_FresnelExponent,varname:node_8533,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_OneMinus,id:5231,x:33833,y:32582,varname:node_5231,prsc:2|IN-7873-OUT;n:type:ShaderForge.SFN_Multiply,id:9530,x:34054,y:32442,varname:node_9530,prsc:2|A-5277-OUT,B-5231-OUT;n:type:ShaderForge.SFN_Vector1,id:5921,x:30888,y:33121,varname:node_5921,prsc:2,v1:1;proporder:1231-9076-4659-6999-9260-5076-8548-6646-4922-8392-3390-2186-8533;pass:END;sub:END;*/

Shader "Custom/Wire" {
    Properties {
        _Speed ("Speed", Float ) = 0.1
        _StripeThickness ("StripeThickness", Float ) = 0.5
        [HDR]_PrimaryColor ("PrimaryColor", Color) = (0,0.9901032,1,1)
        [HDR]_SecondaryColor ("SecondaryColor", Color) = (0,1,0.390867,1)
        _BaseColor ("BaseColor", Color) = (0,0.4985202,0.5188679,1)
        _Metallic ("Metallic", Float ) = 1
        _BaseWireOpacity ("BaseWireOpacity", Float ) = 0.01
        _Gloss ("Gloss", Float ) = 0
        _StripeCount ("StripeCount", Float ) = 2
        _Noise ("Noise", 2D) = "white" {}
        _NoiseSpeed ("NoiseSpeed", Float ) = 0.1
        _NoiseContrast ("NoiseContrast", Float ) = 1.2
        _FresnelExponent ("FresnelExponent", Float ) = 2
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Speed)
                UNITY_DEFINE_INSTANCED_PROP( float, _StripeThickness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _PrimaryColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _BaseWireOpacity)
                UNITY_DEFINE_INSTANCED_PROP( float, _Gloss)
                UNITY_DEFINE_INSTANCED_PROP( float, _StripeCount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _SecondaryColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseContrast)
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelExponent)
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
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float _Gloss_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Gloss );
                float gloss = _Gloss_var;
                float perceptualRoughness = 1.0 - _Gloss_var;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 specularColor = _Metallic_var;
                float specularMonochrome;
                float4 _BaseColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor );
                float3 diffuseColor = _BaseColor_var.rgb; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _PrimaryColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _PrimaryColor );
                float4 _SecondaryColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SecondaryColor );
                float4 node_3013 = _Time;
                float _NoiseSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseSpeed );
                float2 node_4751 = float2(((node_3013.g*_NoiseSpeed_var)+i.uv0.r),i.uv0.g);
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(node_4751, _Noise));
                float _NoiseContrast_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseContrast );
                float node_355 = (_Noise_var.r*_NoiseContrast_var);
                float3 emissive = lerp(_PrimaryColor_var.rgb,_SecondaryColor_var.rgb,node_355);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                float _StripeThickness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _StripeThickness );
                float node_7812 = 0.0;
                float _StripeCount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _StripeCount );
                float node_9592 = fmod((i.uv0.r*_StripeCount_var),1.0);
                float4 node_330 = _Time;
                float _Speed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Speed );
                float node_1050 = fmod((node_330.g*_Speed_var),1.0);
                float node_5921 = 1.0;
                float _BaseWireOpacity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseWireOpacity );
                float _FresnelExponent_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelExponent );
                fixed4 finalRGBA = fixed4(finalColor,(max((lerp(_PrimaryColor_var.a,_SecondaryColor_var.a,node_355)*(1.0 - smoothstep( (_StripeThickness_var+node_7812), node_7812, min(min(distance(node_9592,node_1050),distance(node_9592,(node_1050+node_5921))),distance(node_9592,(node_1050-node_5921))) ))),_BaseWireOpacity_var)*(1.0 - pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExponent_var))));
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
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Speed)
                UNITY_DEFINE_INSTANCED_PROP( float, _StripeThickness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _PrimaryColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _BaseWireOpacity)
                UNITY_DEFINE_INSTANCED_PROP( float, _Gloss)
                UNITY_DEFINE_INSTANCED_PROP( float, _StripeCount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _SecondaryColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseContrast)
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelExponent)
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
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float _Gloss_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Gloss );
                float gloss = _Gloss_var;
                float perceptualRoughness = 1.0 - _Gloss_var;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 specularColor = _Metallic_var;
                float specularMonochrome;
                float4 _BaseColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor );
                float3 diffuseColor = _BaseColor_var.rgb; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float4 _PrimaryColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _PrimaryColor );
                float4 _SecondaryColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SecondaryColor );
                float4 node_3013 = _Time;
                float _NoiseSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseSpeed );
                float2 node_4751 = float2(((node_3013.g*_NoiseSpeed_var)+i.uv0.r),i.uv0.g);
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(node_4751, _Noise));
                float _NoiseContrast_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseContrast );
                float node_355 = (_Noise_var.r*_NoiseContrast_var);
                float _StripeThickness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _StripeThickness );
                float node_7812 = 0.0;
                float _StripeCount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _StripeCount );
                float node_9592 = fmod((i.uv0.r*_StripeCount_var),1.0);
                float4 node_330 = _Time;
                float _Speed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Speed );
                float node_1050 = fmod((node_330.g*_Speed_var),1.0);
                float node_5921 = 1.0;
                float _BaseWireOpacity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseWireOpacity );
                float _FresnelExponent_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelExponent );
                fixed4 finalRGBA = fixed4(finalColor * (max((lerp(_PrimaryColor_var.a,_SecondaryColor_var.a,node_355)*(1.0 - smoothstep( (_StripeThickness_var+node_7812), node_7812, min(min(distance(node_9592,node_1050),distance(node_9592,(node_1050+node_5921))),distance(node_9592,(node_1050-node_5921))) ))),_BaseWireOpacity_var)*(1.0 - pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExponent_var))),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
