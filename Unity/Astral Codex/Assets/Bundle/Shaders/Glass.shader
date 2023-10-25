// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:7993,x:32719,y:32712,varname:node_7993,prsc:2|diff-3178-RGB,spec-3440-RGB,gloss-8098-OUT,normal-1231-RGB,alpha-2817-OUT,refract-5289-OUT;n:type:ShaderForge.SFN_Fresnel,id:9220,x:31417,y:32721,varname:node_9220,prsc:2|EXP-5212-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5212,x:31230,y:32772,ptovrint:False,ptlb:FresnelExp,ptin:_FresnelExp,varname:node_5212,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:5;n:type:ShaderForge.SFN_Color,id:3178,x:31899,y:32469,ptovrint:False,ptlb:BaseColor,ptin:_BaseColor,varname:node_3178,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5186454,c2:0.985945,c3:0.990566,c4:0.05;n:type:ShaderForge.SFN_Tex2d,id:1231,x:32100,y:33226,ptovrint:False,ptlb:NormalMap,ptin:_NormalMap,varname:node_1231,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2607c013c8d667042b21cc87e77dbeba,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Add,id:2856,x:31899,y:32647,varname:node_2856,prsc:2|A-3178-A,B-3343-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8473,x:31417,y:32901,ptovrint:False,ptlb:FresnelStrength,ptin:_FresnelStrength,varname:node_8473,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:3343,x:31661,y:32740,varname:node_3343,prsc:2|A-9220-OUT,B-8473-OUT;n:type:ShaderForge.SFN_ComponentMask,id:3394,x:32317,y:33296,varname:node_3394,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-1231-RGB;n:type:ShaderForge.SFN_ValueProperty,id:4989,x:32317,y:33478,ptovrint:False,ptlb:RefractionStrength,ptin:_RefractionStrength,varname:node_4989,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Multiply,id:5289,x:32486,y:33321,varname:node_5289,prsc:2|A-3394-OUT,B-4989-OUT;n:type:ShaderForge.SFN_ViewPosition,id:295,x:31664,y:32887,varname:node_295,prsc:2;n:type:ShaderForge.SFN_FragmentPosition,id:8788,x:31664,y:33022,varname:node_8788,prsc:2;n:type:ShaderForge.SFN_Distance,id:6327,x:31900,y:32967,varname:node_6327,prsc:2|A-295-XYZ,B-8788-XYZ;n:type:ShaderForge.SFN_Smoothstep,id:6590,x:32084,y:32884,varname:node_6590,prsc:2|A-3738-OUT,B-4132-OUT,V-6327-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3738,x:31900,y:32820,ptovrint:False,ptlb:AlphaDistanceNear,ptin:_AlphaDistanceNear,varname:node_3738,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:100;n:type:ShaderForge.SFN_ValueProperty,id:4132,x:31900,y:32907,ptovrint:False,ptlb:AlphaDistanceFar,ptin:_AlphaDistanceFar,varname:node_4132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1000;n:type:ShaderForge.SFN_Add,id:9286,x:32259,y:32803,varname:node_9286,prsc:2|A-2856-OUT,B-6590-OUT;n:type:ShaderForge.SFN_Clamp01,id:2817,x:32417,y:32803,varname:node_2817,prsc:2|IN-9286-OUT;n:type:ShaderForge.SFN_Color,id:3440,x:32367,y:32283,ptovrint:False,ptlb:SpecularColor,ptin:_SpecularColor,varname:node_3440,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.007393122,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:8098,x:32367,y:32469,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_8098,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.25;proporder:5212-3178-1231-8473-4989-3738-4132-3440-8098;pass:END;sub:END;*/

Shader "Custom/Glass" {
    Properties {
        _FresnelExp ("FresnelExp", Float ) = 5
        _BaseColor ("BaseColor", Color) = (0.5186454,0.985945,0.990566,0.05)
        _NormalMap ("NormalMap", 2D) = "bump" {}
        _FresnelStrength ("FresnelStrength", Float ) = 0.5
        _RefractionStrength ("RefractionStrength", Float ) = 0.1
        _AlphaDistanceNear ("AlphaDistanceNear", Float ) = 100
        _AlphaDistanceFar ("AlphaDistanceFar", Float ) = 1000
        _SpecularColor ("SpecularColor", Color) = (0.007393122,1,0,1)
        _Gloss ("Gloss", Float ) = 0.25
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        GrabPass{ }
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
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelExp)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _AlphaDistanceNear)
                UNITY_DEFINE_INSTANCED_PROP( float, _AlphaDistanceFar)
                UNITY_DEFINE_INSTANCED_PROP( float4, _SpecularColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _Gloss)
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
                float4 projPos : TEXCOORD5;
                UNITY_FOG_COORDS(6)
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
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(i.uv0, _NormalMap)));
                float3 normalLocal = _NormalMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float _RefractionStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionStrength );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (_NormalMap_var.rgb.rg*_RefractionStrength_var);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float _Gloss_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Gloss );
                float gloss = _Gloss_var;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float4 _SpecularColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SpecularColor );
                float3 specularColor = _SpecularColor_var.rgb;
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _BaseColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor );
                float3 diffuseColor = _BaseColor_var.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float _FresnelExp_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelExp );
                float _FresnelStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelStrength );
                float _AlphaDistanceNear_var = UNITY_ACCESS_INSTANCED_PROP( Props, _AlphaDistanceNear );
                float _AlphaDistanceFar_var = UNITY_ACCESS_INSTANCED_PROP( Props, _AlphaDistanceFar );
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,saturate(((_BaseColor_var.a+(pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExp_var)*_FresnelStrength_var))+smoothstep( _AlphaDistanceNear_var, _AlphaDistanceFar_var, distance(_WorldSpaceCameraPos,i.posWorld.rgb) )))),1);
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
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelExp)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _AlphaDistanceNear)
                UNITY_DEFINE_INSTANCED_PROP( float, _AlphaDistanceFar)
                UNITY_DEFINE_INSTANCED_PROP( float4, _SpecularColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _Gloss)
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
                float4 projPos : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
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
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(i.uv0, _NormalMap)));
                float3 normalLocal = _NormalMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float _RefractionStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionStrength );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (_NormalMap_var.rgb.rg*_RefractionStrength_var);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float _Gloss_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Gloss );
                float gloss = _Gloss_var;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float4 _SpecularColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SpecularColor );
                float3 specularColor = _SpecularColor_var.rgb;
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 _BaseColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor );
                float3 diffuseColor = _BaseColor_var.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float _FresnelExp_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelExp );
                float _FresnelStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelStrength );
                float _AlphaDistanceNear_var = UNITY_ACCESS_INSTANCED_PROP( Props, _AlphaDistanceNear );
                float _AlphaDistanceFar_var = UNITY_ACCESS_INSTANCED_PROP( Props, _AlphaDistanceFar );
                fixed4 finalRGBA = fixed4(finalColor * saturate(((_BaseColor_var.a+(pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExp_var)*_FresnelStrength_var))+smoothstep( _AlphaDistanceNear_var, _AlphaDistanceFar_var, distance(_WorldSpaceCameraPos,i.posWorld.rgb) ))),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
