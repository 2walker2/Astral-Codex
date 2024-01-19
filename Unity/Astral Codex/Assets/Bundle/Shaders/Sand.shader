// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4962,x:32719,y:32712,varname:node_4962,prsc:2|diff-7360-OUT,spec-1347-OUT,gloss-5324-OUT,normal-2335-OUT,amdfl-4153-OUT,amspl-2908-OUT;n:type:ShaderForge.SFN_Tex2d,id:1383,x:31740,y:32109,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_1383,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:33272c6c8b0479243a4956dc2aecbe02,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:7360,x:32005,y:31890,varname:node_7360,prsc:2|A-168-RGB,B-1687-RGB,T-1383-A;n:type:ShaderForge.SFN_Color,id:168,x:31740,y:31765,ptovrint:False,ptlb:Color1,ptin:_Color1,varname:node_168,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.8645523,c3:0.1647059,c4:1;n:type:ShaderForge.SFN_Color,id:1687,x:31740,y:31933,ptovrint:False,ptlb:Color2,ptin:_Color2,varname:node_1687,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.7290326,c3:0.1647059,c4:1;n:type:ShaderForge.SFN_Tex2d,id:25,x:31507,y:33224,ptovrint:False,ptlb:NormalMap,ptin:_NormalMap,varname:node_25,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:True,tex:23e5ec1e54051c54fa8266966f96409c,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Multiply,id:3067,x:31800,y:33318,varname:node_3067,prsc:2|A-25-B,B-4899-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5164,x:31359,y:33484,ptovrint:False,ptlb:NormalStrength,ptin:_NormalStrength,varname:node_5164,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_ComponentMask,id:4167,x:31800,y:33163,varname:node_4167,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-25-RGB;n:type:ShaderForge.SFN_Append,id:2335,x:32042,y:33250,varname:node_2335,prsc:2|A-4167-OUT,B-3067-OUT;n:type:ShaderForge.SFN_Divide,id:4899,x:31542,y:33450,varname:node_4899,prsc:2|A-8833-OUT,B-5164-OUT;n:type:ShaderForge.SFN_Vector1,id:8833,x:31359,y:33392,varname:node_8833,prsc:2,v1:1;n:type:ShaderForge.SFN_Tex2d,id:177,x:31548,y:32819,ptovrint:False,ptlb:MetallicMap,ptin:_MetallicMap,varname:node_177,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:0ec4550db1f429a4e814934b5e3bbe1a,ntxv:3,isnm:True;n:type:ShaderForge.SFN_ValueProperty,id:2526,x:31548,y:32660,ptovrint:False,ptlb:MetallicMin,ptin:_MetallicMin,varname:node_2526,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:5165,x:31548,y:32736,ptovrint:False,ptlb:MetallicMax,ptin:_MetallicMax,varname:node_5165,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Lerp,id:1347,x:31863,y:32654,varname:node_1347,prsc:2|A-2526-OUT,B-5165-OUT,T-177-R;n:type:ShaderForge.SFN_ValueProperty,id:2677,x:31548,y:33015,ptovrint:False,ptlb:GlossMin,ptin:_GlossMin,varname:node_2677,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Lerp,id:5324,x:31877,y:32927,varname:node_5324,prsc:2|A-2677-OUT,B-901-OUT,T-177-G;n:type:ShaderForge.SFN_ValueProperty,id:901,x:31548,y:33094,ptovrint:False,ptlb:GlossMax,ptin:_GlossMax,varname:node_901,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_ValueProperty,id:4153,x:32137,y:32770,ptovrint:False,ptlb:DiffuseAmbientLight,ptin:_DiffuseAmbientLight,varname:node_4153,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.1;n:type:ShaderForge.SFN_ValueProperty,id:2908,x:32137,y:32849,ptovrint:False,ptlb:SpecularAmbientLight,ptin:_SpecularAmbientLight,varname:node_2908,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.05;proporder:1383-168-1687-25-5164-177-2526-5165-2677-901-4153-2908;pass:END;sub:END;*/

Shader "Custom/Sand" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _Color1 ("Color1", Color) = (1,0.8645523,0.1647059,1)
        _Color2 ("Color2", Color) = (1,0.7290326,0.1647059,1)
        [Normal]_NormalMap ("NormalMap", 2D) = "bump" {}
        _NormalStrength ("NormalStrength", Float ) = 0.5
        _MetallicMap ("MetallicMap", 2D) = "bump" {}
        _MetallicMin ("MetallicMin", Float ) = 0
        _MetallicMax ("MetallicMax", Float ) = 0
        _GlossMin ("GlossMin", Float ) = 1
        _GlossMax ("GlossMax", Float ) = 2
        _DiffuseAmbientLight ("DiffuseAmbientLight", Float ) = -0.1
        _SpecularAmbientLight ("SpecularAmbientLight", Float ) = -0.05
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform sampler2D _MetallicMap; uniform float4 _MetallicMap_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color1)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color2)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormalStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _MetallicMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _MetallicMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _GlossMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _GlossMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _DiffuseAmbientLight)
                UNITY_DEFINE_INSTANCED_PROP( float, _SpecularAmbientLight)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
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
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(i.uv0, _NormalMap)));
                float _NormalStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormalStrength );
                float3 normalLocal = float3(_NormalMap_var.rgb.rg,(_NormalMap_var.b*(1.0/_NormalStrength_var)));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float _GlossMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _GlossMin );
                float _GlossMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _GlossMax );
                float3 _MetallicMap_var = UnpackNormal(tex2D(_MetallicMap,TRANSFORM_TEX(i.uv0, _MetallicMap)));
                float gloss = lerp(_GlossMin_var,_GlossMax_var,_MetallicMap_var.g);
                float perceptualRoughness = 1.0 - lerp(_GlossMin_var,_GlossMax_var,_MetallicMap_var.g);
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
                float _SpecularAmbientLight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SpecularAmbientLight );
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float _MetallicMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MetallicMin );
                float _MetallicMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MetallicMax );
                float3 specularColor = lerp(_MetallicMin_var,_MetallicMax_var,_MetallicMap_var.r);
                float specularMonochrome;
                float4 _Color1_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color1 );
                float4 _Color2_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color2 );
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 diffuseColor = lerp(_Color1_var.rgb,_Color2_var.rgb,_MainTex_var.a); // Need this for specular when using metallic
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
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (0 + float3(_SpecularAmbientLight_var,_SpecularAmbientLight_var,_SpecularAmbientLight_var));
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float _DiffuseAmbientLight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DiffuseAmbientLight );
                indirectDiffuse += float3(_DiffuseAmbientLight_var,_DiffuseAmbientLight_var,_DiffuseAmbientLight_var); // Diffuse Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform sampler2D _MetallicMap; uniform float4 _MetallicMap_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color1)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color2)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormalStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _MetallicMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _MetallicMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _GlossMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _GlossMax)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
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
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(i.uv0, _NormalMap)));
                float _NormalStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormalStrength );
                float3 normalLocal = float3(_NormalMap_var.rgb.rg,(_NormalMap_var.b*(1.0/_NormalStrength_var)));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float _GlossMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _GlossMin );
                float _GlossMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _GlossMax );
                float3 _MetallicMap_var = UnpackNormal(tex2D(_MetallicMap,TRANSFORM_TEX(i.uv0, _MetallicMap)));
                float gloss = lerp(_GlossMin_var,_GlossMax_var,_MetallicMap_var.g);
                float perceptualRoughness = 1.0 - lerp(_GlossMin_var,_GlossMax_var,_MetallicMap_var.g);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float _MetallicMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MetallicMin );
                float _MetallicMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MetallicMax );
                float3 specularColor = lerp(_MetallicMin_var,_MetallicMax_var,_MetallicMap_var.r);
                float specularMonochrome;
                float4 _Color1_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color1 );
                float4 _Color2_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color2 );
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 diffuseColor = lerp(_Color1_var.rgb,_Color2_var.rgb,_MainTex_var.a); // Need this for specular when using metallic
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
