// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:8830,x:33663,y:32648,varname:node_8830,prsc:2|emission-8007-OUT,lwrap-892-OUT,alpha-8293-OUT;n:type:ShaderForge.SFN_Distance,id:2843,x:30418,y:32089,varname:node_2843,prsc:2|A-8792-UVOUT,B-2871-OUT;n:type:ShaderForge.SFN_TexCoord,id:8792,x:30239,y:32020,varname:node_8792,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Vector2,id:2871,x:30239,y:32185,varname:node_2871,prsc:2,v1:0.5,v2:0.5;n:type:ShaderForge.SFN_ValueProperty,id:3725,x:31856,y:32481,ptovrint:False,ptlb:Edge Rotate Speed,ptin:_EdgeRotateSpeed,varname:node_3725,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.025;n:type:ShaderForge.SFN_Rotator,id:3865,x:32068,y:32386,varname:node_3865,prsc:2|UVIN-4879-OUT,SPD-3725-OUT;n:type:ShaderForge.SFN_TexCoord,id:7979,x:30775,y:32297,varname:node_7979,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Vector2,id:5531,x:30775,y:32465,varname:node_5531,prsc:2,v1:0.5,v2:0.5;n:type:ShaderForge.SFN_Subtract,id:3420,x:30966,y:32388,varname:node_3420,prsc:2|A-7979-UVOUT,B-5531-OUT;n:type:ShaderForge.SFN_Multiply,id:957,x:31135,y:32388,varname:node_957,prsc:2|A-3420-OUT,B-6680-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8324,x:30769,y:32236,ptovrint:False,ptlb:Edge Stretch,ptin:_EdgeStretch,varname:node_8324,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.25;n:type:ShaderForge.SFN_Add,id:4879,x:31301,y:32388,varname:node_4879,prsc:2|A-957-OUT,B-5531-OUT;n:type:ShaderForge.SFN_OneMinus,id:7306,x:30769,y:32092,varname:node_7306,prsc:2|IN-5187-OUT;n:type:ShaderForge.SFN_Multiply,id:6680,x:30926,y:32133,varname:node_6680,prsc:2|A-7306-OUT,B-8324-OUT;n:type:ShaderForge.SFN_Divide,id:5187,x:30602,y:32113,varname:node_5187,prsc:2|A-2843-OUT,B-2884-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2884,x:30418,y:32245,ptovrint:False,ptlb:Edge Distance Adjustment,ptin:_EdgeDistanceAdjustment,varname:node_2884,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Tex2dAsset,id:3059,x:32013,y:32594,ptovrint:False,ptlb:Foam Edge Texture,ptin:_FoamEdgeTexture,varname:node_3059,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:0061a585379882e468fb08cbbec6205c,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:5648,x:32230,y:32398,varname:node_5648,prsc:2,tex:0061a585379882e468fb08cbbec6205c,ntxv:0,isnm:False|UVIN-3865-UVOUT,TEX-3059-TEX;n:type:ShaderForge.SFN_ValueProperty,id:1951,x:31850,y:32900,ptovrint:False,ptlb:Secondary Edge Rotate Speed,ptin:_SecondaryEdgeRotateSpeed,varname:node_1951,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.02;n:type:ShaderForge.SFN_Rotator,id:8053,x:32013,y:32812,varname:node_8053,prsc:2|UVIN-6730-UVOUT,SPD-1951-OUT;n:type:ShaderForge.SFN_Tex2d,id:3475,x:32245,y:32743,varname:node_3475,prsc:2,tex:0061a585379882e468fb08cbbec6205c,ntxv:0,isnm:False|UVIN-8053-UVOUT,TEX-3059-TEX;n:type:ShaderForge.SFN_TexCoord,id:6730,x:31460,y:32742,varname:node_6730,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:7288,x:32792,y:32605,varname:node_7288,prsc:2|A-5648-RGB,B-3475-RGB;n:type:ShaderForge.SFN_Add,id:9094,x:32792,y:32835,varname:node_9094,prsc:2|A-5648-A,B-716-OUT;n:type:ShaderForge.SFN_Divide,id:3357,x:33019,y:32605,varname:node_3357,prsc:2|A-7288-OUT,B-275-OUT;n:type:ShaderForge.SFN_Vector1,id:275,x:32808,y:32757,varname:node_275,prsc:2,v1:2;n:type:ShaderForge.SFN_Divide,id:6986,x:33019,y:32835,varname:node_6986,prsc:2|A-9094-OUT,B-275-OUT;n:type:ShaderForge.SFN_Multiply,id:716,x:32543,y:32858,varname:node_716,prsc:2|A-3475-A,B-6796-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6796,x:32337,y:32938,ptovrint:False,ptlb:Secondary Edge Alpha,ptin:_SecondaryEdgeAlpha,varname:node_6796,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_ValueProperty,id:892,x:33468,y:32821,ptovrint:False,ptlb:Light Wrapping,ptin:_LightWrapping,varname:node_892,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Color,id:3043,x:32841,y:32373,ptovrint:False,ptlb:Tint,ptin:_Tint,varname:node_3043,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:8007,x:33347,y:32649,varname:node_8007,prsc:2|A-5304-OUT,B-3357-OUT;n:type:ShaderForge.SFN_Add,id:5304,x:33069,y:32373,varname:node_5304,prsc:2|A-3043-RGB,B-2479-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2479,x:32891,y:32282,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_2479,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:9662,x:33202,y:32835,varname:node_9662,prsc:2|A-3043-A,B-6986-OUT;n:type:ShaderForge.SFN_ValueProperty,id:328,x:32823,y:33081,ptovrint:False,ptlb:FadeDistanceMin,ptin:_FadeDistanceMin,varname:node_328,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_ValueProperty,id:4835,x:32823,y:33157,ptovrint:False,ptlb:FadeDistanceMax,ptin:_FadeDistanceMax,varname:node_4835,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Smoothstep,id:9753,x:33031,y:33102,varname:node_9753,prsc:2|A-328-OUT,B-4835-OUT,V-2668-OUT;n:type:ShaderForge.SFN_Multiply,id:8293,x:33430,y:32881,varname:node_8293,prsc:2|A-9662-OUT,B-690-OUT;n:type:ShaderForge.SFN_OneMinus,id:690,x:33192,y:33102,varname:node_690,prsc:2|IN-9753-OUT;n:type:ShaderForge.SFN_ViewPosition,id:3866,x:32621,y:33292,varname:node_3866,prsc:2;n:type:ShaderForge.SFN_ObjectPosition,id:3384,x:32621,y:33420,varname:node_3384,prsc:2;n:type:ShaderForge.SFN_Distance,id:2668,x:32823,y:33352,varname:node_2668,prsc:2|A-3866-XYZ,B-3384-XYZ;proporder:3725-8324-2884-3059-1951-6796-892-3043-2479-328-4835;pass:END;sub:END;*/

Shader "Custom/Whirlpool" {
    Properties {
        _EdgeRotateSpeed ("Edge Rotate Speed", Float ) = 0.025
        _EdgeStretch ("Edge Stretch", Float ) = 0.25
        _EdgeDistanceAdjustment ("Edge Distance Adjustment", Float ) = 0.1
        _FoamEdgeTexture ("Foam Edge Texture", 2D) = "white" {}
        _SecondaryEdgeRotateSpeed ("Secondary Edge Rotate Speed", Float ) = 0.02
        _SecondaryEdgeAlpha ("Secondary Edge Alpha", Float ) = 0.5
        _LightWrapping ("Light Wrapping", Float ) = 0
        _Tint ("Tint", Color) = (1,1,1,1)
        _Brightness ("Brightness", Float ) = 0
        _FadeDistanceMin ("FadeDistanceMin", Float ) = 0.5
        _FadeDistanceMax ("FadeDistanceMax", Float ) = 1
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
            uniform sampler2D _FoamEdgeTexture; uniform float4 _FoamEdgeTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _EdgeRotateSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _EdgeStretch)
                UNITY_DEFINE_INSTANCED_PROP( float, _EdgeDistanceAdjustment)
                UNITY_DEFINE_INSTANCED_PROP( float, _SecondaryEdgeRotateSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _SecondaryEdgeAlpha)
                UNITY_DEFINE_INSTANCED_PROP( float, _LightWrapping)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Tint)
                UNITY_DEFINE_INSTANCED_PROP( float, _Brightness)
                UNITY_DEFINE_INSTANCED_PROP( float, _FadeDistanceMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _FadeDistanceMax)
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
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
////// Lighting:
////// Emissive:
                float4 _Tint_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Tint );
                float _Brightness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Brightness );
                float4 node_853 = _Time;
                float _EdgeRotateSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _EdgeRotateSpeed );
                float node_3865_ang = node_853.g;
                float node_3865_spd = _EdgeRotateSpeed_var;
                float node_3865_cos = cos(node_3865_spd*node_3865_ang);
                float node_3865_sin = sin(node_3865_spd*node_3865_ang);
                float2 node_3865_piv = float2(0.5,0.5);
                float2 node_5531 = float2(0.5,0.5);
                float _EdgeDistanceAdjustment_var = UNITY_ACCESS_INSTANCED_PROP( Props, _EdgeDistanceAdjustment );
                float _EdgeStretch_var = UNITY_ACCESS_INSTANCED_PROP( Props, _EdgeStretch );
                float2 node_3865 = (mul((((i.uv0-node_5531)*((1.0 - (distance(i.uv0,float2(0.5,0.5))/_EdgeDistanceAdjustment_var))*_EdgeStretch_var))+node_5531)-node_3865_piv,float2x2( node_3865_cos, -node_3865_sin, node_3865_sin, node_3865_cos))+node_3865_piv);
                float4 node_5648 = tex2D(_FoamEdgeTexture,TRANSFORM_TEX(node_3865, _FoamEdgeTexture));
                float _SecondaryEdgeRotateSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SecondaryEdgeRotateSpeed );
                float node_8053_ang = node_853.g;
                float node_8053_spd = _SecondaryEdgeRotateSpeed_var;
                float node_8053_cos = cos(node_8053_spd*node_8053_ang);
                float node_8053_sin = sin(node_8053_spd*node_8053_ang);
                float2 node_8053_piv = float2(0.5,0.5);
                float2 node_8053 = (mul(i.uv0-node_8053_piv,float2x2( node_8053_cos, -node_8053_sin, node_8053_sin, node_8053_cos))+node_8053_piv);
                float4 node_3475 = tex2D(_FoamEdgeTexture,TRANSFORM_TEX(node_8053, _FoamEdgeTexture));
                float node_275 = 2.0;
                float3 emissive = ((_Tint_var.rgb+_Brightness_var)*((node_5648.rgb+node_3475.rgb)/node_275));
                float3 finalColor = emissive;
                float _SecondaryEdgeAlpha_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SecondaryEdgeAlpha );
                float _FadeDistanceMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FadeDistanceMin );
                float _FadeDistanceMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FadeDistanceMax );
                fixed4 finalRGBA = fixed4(finalColor,((_Tint_var.a*((node_5648.a+(node_3475.a*_SecondaryEdgeAlpha_var))/node_275))*(1.0 - smoothstep( _FadeDistanceMin_var, _FadeDistanceMax_var, distance(_WorldSpaceCameraPos,objPos.rgb) ))));
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
