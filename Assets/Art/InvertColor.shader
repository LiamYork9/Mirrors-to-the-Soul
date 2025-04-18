Shader "Custom/2D/InvertColor"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Threshold ("Threshold", Range(0., 1.)) = 0
        _Color ("Tint Color", Color) = (1,1,1,1)

    }

    
    
    SubShader
    {
        Tags {"Queue"="Transparent" "RenderType"="Transparent"}
        Cull Off
        Blend SrcAlpha OneMinusSrcAlpha
 
        Pass
        {
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
           
            #include "UnityCG.cginc"
 
            sampler2D _MainTex;
            float _Threshold;
            fixed4 _Color;
 
            fixed4 frag (v2f_img i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv) * _Color;
                col.rgb = abs(_Threshold - col.rgb);
                return col;
            }

            ENDCG
        }
    }
}
