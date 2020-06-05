set(project_name "opengl_test")
cmake_minimum_required(VERSION 3.15)
project(${project_name})

set(CMAKE_CXX_STANDARD 14)


# 添加头文件
set(GLEW_H /usr/local/Cellar/glew/2.1.0/include)
set(GLFW_H /usr/local/Cellar/glfw/3.3.2/include)
#set(GLAD_H /usr/local/include/glad)
#set(KH_H /usr/local/include/KHR)
set(INCLUDE_H /usr/local/include)
include_directories(${GLEW_H} ${GLFW_H} ${INCLUDE_H})
#
# 添加目标链接
set(GLEW_LINK /usr/local/Cellar/glew/2.1.0/lib/libGLEW.2.1.dylib)
set(GLFW_LINK /usr/local/Cellar/glfw/3.3.2/lib/libglfw.3.dylib)
link_libraries(${OPENGL} ${GLEW_LINK} ${GLFW_LINK})

FILE(GLOB files
        "cpp/*.h"
        "cpp/*.cpp"
        "cpp/*.c"
        "cpp/util/*.h"
        "cpp/util/*.cpp"
        )


add_executable(${project_name} ${files})

# mac下这步很重要
if (APPLE)
    target_link_libraries(${project_name} "-framework OpenGL")
    target_link_libraries(${project_name} "-framework GLUT")
endif()