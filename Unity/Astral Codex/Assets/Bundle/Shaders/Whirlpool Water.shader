// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9939,x:33110,y:32684,varname:node_9939,prsc:2|diff-5570-OUT,normal-4703-OUT,alpha-3411-OUT,refract-5452-OUT;n:type:ShaderForge.SFN_Tex2d,id:8521,x:31862,y:32980,ptovrint:False,ptlb:Refraction Map,ptin:_RefractionMap,varname:node_8521,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1bfbf56a34346ab46b4bd9baaf585b2d,ntxv:3,isnm:True|UVIN-7538-UVOUT;n:type:ShaderForge.SFN_ComponentMask,id:5945,x:32072,y:32776,varname:node_5945,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8521-RGB;n:type:ShaderForge.SFN_TexCoord,id:3805,x:30526,y:32654,varname:node_3805,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Vector2,id:8830,x:30526,y:32836,varname:node_8830,prsc:2,v1:0.5,v2:0.5;n:type:ShaderForge.SFN_Distance,id:1088,x:30718,y:32716,varname:node_1088,prsc:2|A-3805-UVOUT,B-8830-OUT;n:type:ShaderForge.SFN_Multiply,id:1867,x:32257,y:32687,varname:node_1867,prsc:2|A-1903-OUT,B-5945-OUT;n:type:ShaderForge.SFN_Smoothstep,id:3856,x:31913,y:32628,varname:node_3856,prsc:2|A-6085-OUT,B-5106-OUT,V-1088-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6085,x:31709,y:32460,ptovrint:False,ptlb:Refraction Inner Radius,ptin:_RefractionInnerRadius,varname:node_6085,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.25;n:type:ShaderForge.SFN_ValueProperty,id:5106,x:31709,y:32538,ptovrint:False,ptlb:Refraction Outer Radius,ptin:_RefractionOuterRadius,varname:node_5106,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_OneMinus,id:1903,x:32072,y:32628,varname:node_1903,prsc:2|IN-3856-OUT;n:type:ShaderForge.SFN_Rotator,id:6068,x:31153,y:33082,varname:node_6068,prsc:2|UVIN-3607-UVOUT,ANG-8881-OUT;n:type:ShaderForge.SFN_TexCoord,id:3607,x:30762,y:33133,varname:node_3607,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:306,x:30803,y:32932,ptovrint:False,ptlb:Base,ptin:_Base,varname:node_306,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Multiply,id:8881,x:30978,y:32898,varname:node_8881,prsc:2|A-1088-OUT,B-306-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9669,x:31142,y:33309,ptovrint:False,ptlb:Rotation Speed,ptin:_RotationSpeed,varname:node_9669,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Rotator,id:7538,x:31360,y:33082,varname:node_7538,prsc:2|UVIN-6068-UVOUT,SPD-9669-OUT;n:type:ShaderForge.SFN_Color,id:233,x:32113,y:32288,ptovrint:False,ptlb:Base Color,ptin:_BaseColor,varname:node_233,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.6886792,c3:0.609996,c4:0.1176471;n:type:ShaderForge.SFN_Multiply,id:8651,x:32334,y:32288,varname:node_8651,prsc:2|A-233-RGB,B-1903-OUT;n:type:ShaderForge.SFN_Multiply,id:2584,x:32334,y:32418,varname:node_2584,prsc:2|A-233-A,B-1903-OUT;n:type:ShaderForge.SFN_Multiply,id:4703,x:32177,y:32982,varname:node_4703,prsc:2|A-8521-RGB,B-6448-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6448,x:32010,y:33065,ptovrint:False,ptlb:Normal Strength,ptin:_NormalStrength,varname:node_6448,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:8674,x:32240,y:32872,ptovrint:False,ptlb:Refraction Strength,ptin:_RefractionStrength,varname:node_8674,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:172,x:32426,y:32737,varname:node_172,prsc:2|A-1867-OUT,B-8674-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4481,x:31930,y:31884,ptovrint:False,ptlb:FadeDistanceMin,ptin:_FadeDistanceMin,varname:node_4481,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:4279,x:31930,y:31975,ptovrint:False,ptlb:FadeDistanceMax,ptin:_FadeDistanceMax,varname:node_4279,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ViewPosition,id:4308,x:31726,y:31975,varname:node_4308,prsc:2;n:type:ShaderForge.SFN_ObjectPosition,id:5426,x:31726,y:32099,varname:node_5426,prsc:2;n:type:ShaderForge.SFN_Distance,id:578,x:31930,y:32063,varname:node_578,prsc:2|A-4308-XYZ,B-5426-XYZ;n:type:ShaderForge.SFN_Smoothstep,id:4336,x:32135,y:31958,varname:node_4336,prsc:2|A-4481-OUT,B-4279-OUT,V-578-OUT;n:type:ShaderForge.SFN_Multiply,id:5570,x:32771,y:32461,varname:node_5570,prsc:2|A-4149-OUT,B-8651-OUT;n:type:ShaderForge.SFN_Multiply,id:3411,x:32771,y:32609,varname:node_3411,prsc:2|A-4149-OUT,B-2584-OUT;n:type:ShaderForge.SFN_Multiply,id:5452,x:32771,y:32776,varname:node_5452,prsc:2|A-4149-OUT,B-172-OUT;n:type:ShaderForge.SFN_OneMinus,id:4149,x:32321,y:31958,varname:node_4149,prsc:2|IN-4336-OUT;proporder:8521-6085-5106-306-9669-233-6448-8674-4481-4279;pass:END;sub:END;*/

Shader "Custom/Refraction" {
    Properties {
        _RefractionMap ("Refraction Map", 2D) = "bump" {}
        _RefractionInnerRadius ("Refraction Inner Radius", Float ) = 0.25
        _RefractionOuterRadius ("Refraction Outer Radius", Float ) = 0.5
        _Base ("Base", Float ) = 10
        _RotationSpeed ("Rotation Speed", Float ) = 1
        _BaseColor ("Base Color", Color) = (0,0.6886792,0.609996,0.1176471)
        _NormalStrength ("Normal Strength", Float ) = 0
        _RefractionStrength ("Refraction Strength", Float ) = 1
        _FadeDistanceMin ("FadeDistanceMin", Float ) = 0
        _FadeDistanceMax ("FadeDistanceMax", Float ) = 0
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
            Cull Off
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
            uniform sampler2D _RefractionMap; uniform float4 _RefractionMap_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionInnerRadius)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionOuterRadius)
                UNITY_DEFINE_INSTANCED_PROP( float, _Base)
                UNITY_DEFINE_INSTANCED_PROP( float, _RotationSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormalStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _FadeDistanceMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _FadeDistanceMax)
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
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_8782 = _Time;
                float _RotationSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RotationSpeed );
                float node_7538_ang = node_8782.g;
                float node_7538_spd = _RotationSpeed_var;
                float node_7538_cos = cos(node_7538_spd*node_7538_ang);
                float node_7538_sin = sin(node_7538_spd*node_7538_ang);
                float2 node_7538_piv = float2(0.5,0.5);
                float node_1088 = distance(i.uv0,float2(0.5,0.5));
                float _Base_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Base );
                float node_6068_ang = (node_1088*_Base_var);
                float node_6068_spd = 1.0;
                float node_6068_cos = cos(node_6068_spd*node_6068_ang);
                float node_6068_sin = sin(node_6068_spd*node_6068_ang);
                float2 node_6068_piv = float2(0.5,0.5);
                float2 node_6068 = (mul(i.uv0-node_6068_piv,float2x2( node_6068_cos, -node_6068_sin, node_6068_sin, node_6068_cos))+node_6068_piv);
                float2 node_7538 = (mul(node_6068-node_7538_piv,float2x2( node_7538_cos, -node_7538_sin, node_7538_sin, node_7538_cos))+node_7538_piv);
                float3 _RefractionMap_var = UnpackNormal(tex2D(_RefractionMap,TRANSFORM_TEX(node_7538, _RefractionMap)));
                float _NormalStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormalStrength );
                float3 normalLocal = (_RefractionMap_var.rgb*_NormalStrength_var);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float _FadeDistanceMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FadeDistanceMin );
                float _FadeDistanceMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FadeDistanceMax );
                float node_4149 = (1.0 - smoothstep( _FadeDistanceMin_var, _FadeDistanceMax_var, distance(_WorldSpaceCameraPos,objPos.rgb) ));
                float _RefractionInnerRadius_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionInnerRadius );
                float _RefractionOuterRadius_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionOuterRadius );
                float node_1903 = (1.0 - smoothstep( _RefractionInnerRadius_var, _RefractionOuterRadius_var, node_1088 ));
                float _RefractionStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionStrength );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (node_4149*((node_1903*_RefractionMap_var.rgb.rg)*_RefractionStrength_var));
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _BaseColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor );
                float3 diffuseColor = (node_4149*(_BaseColor_var.rgb*node_1903));
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,(node_4149*(_BaseColor_var.a*node_1903))),1);
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
            Cull Off
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
            uniform sampler2D _RefractionMap; uniform float4 _RefractionMap_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionInnerRadius)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionOuterRadius)
                UNITY_DEFINE_INSTANCED_PROP( float, _Base)
                UNITY_DEFINE_INSTANCED_PROP( float, _RotationSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormalStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _FadeDistanceMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _FadeDistanceMax)
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
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_6862 = _Time;
                float _RotationSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RotationSpeed );
                float node_7538_ang = node_6862.g;
                float node_7538_spd = _RotationSpeed_var;
                float node_7538_cos = cos(node_7538_spd*node_7538_ang);
                float node_7538_sin = sin(node_7538_spd*node_7538_ang);
                float2 node_7538_piv = float2(0.5,0.5);
                float node_1088 = distance(i.uv0,float2(0.5,0.5));
                float _Base_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Base );
                float node_6068_ang = (node_1088*_Base_var);
                float node_6068_spd = 1.0;
                float node_6068_cos = cos(node_6068_spd*node_6068_ang);
                float node_6068_sin = sin(node_6068_spd*node_6068_ang);
                float2 node_6068_piv = float2(0.5,0.5);
                float2 node_6068 = (mul(i.uv0-node_6068_piv,float2x2( node_6068_cos, -node_6068_sin, node_6068_sin, node_6068_cos))+node_6068_piv);
                float2 node_7538 = (mul(node_6068-node_7538_piv,float2x2( node_7538_cos, -node_7538_sin, node_7538_sin, node_7538_cos))+node_7538_piv);
                float3 _RefractionMap_var = UnpackNormal(tex2D(_RefractionMap,TRANSFORM_TEX(node_7538, _RefractionMap)));
                float _NormalStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormalStrength );
                float3 normalLocal = (_RefractionMap_var.rgb*_NormalStrength_var);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float _FadeDistanceMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FadeDistanceMin );
                float _FadeDistanceMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FadeDistanceMax );
                float node_4149 = (1.0 - smoothstep( _FadeDistanceMin_var, _FadeDistanceMax_var, distance(_WorldSpaceCameraPos,objPos.rgb) ));
                float _RefractionInnerRadius_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionInnerRadius );
                float _RefractionOuterRadius_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionOuterRadius );
                float node_1903 = (1.0 - smoothstep( _RefractionInnerRadius_var, _RefractionOuterRadius_var, node_1088 ));
                float _RefractionStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionStrength );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (node_4149*((node_1903*_RefractionMap_var.rgb.rg)*_RefractionStrength_var));
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 _BaseColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor );
                float3 diffuseColor = (node_4149*(_BaseColor_var.rgb*node_1903));
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * (node_4149*(_BaseColor_var.a*node_1903)),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
