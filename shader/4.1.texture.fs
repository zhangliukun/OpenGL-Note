#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D ourTexture;

void main()
{
    //FragColor = texture(ourTexture, TexCoord);//原纹理
//     FragColor = vec4(ourColor,1.0);//原图
    FragColor = texture(ourTexture, TexCoord) * vec4(ourColor, 1.0); // 将纹理颜色与定点颜色混合

}