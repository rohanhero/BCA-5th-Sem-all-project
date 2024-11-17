// import org.lwjgl.*;
// import org.lwjgl.glfw.*;
// import org.lwjgl.opengl.*;
// import org.lwjgl.system.*;

// import java.nio.*;

// import static org.lwjgl.glfw.Callbacks.*;
// import static org.lwjgl.opengl.GL11.*;
// import static org.lwjgl.opengl.GL20.*;
// import static org.lwjgl.system.MemoryStack.*;
// import static org.lwjgl.system.MemoryUtil.*;

// public class OpenGLTest {
//     private long window;
//     private float angle = 0.0f;

//     public void run() {
//         init();
//         loop();
//         cleanup();
//     }

//     private void init() {
//         // Initialize GLFW
//         if (!glfwInit())
//             throw new IllegalStateException("Unable to initialize GLFW");

//         // Create the window
//         window = glfwCreateWindow(800, 600, "Rotating Triangle", NULL, NULL);
//         if (window == NULL)
//             throw new RuntimeException("Failed to create the GLFW window");

//         glfwMakeContextCurrent(window);
//         glfwShowWindow(window);
//         GL.createCapabilities();
//     }

//     private void loop() {
//         while (!glfwWindowShouldClose(window)) {
//             glClear(GL_COLOR_BUFFER_BIT);

//             // Set the color and draw the triangle
//             glLoadIdentity();
//             glTranslatef(0.0f, 0.0f, -5.0f);
//             glRotatef(angle, 0.0f, 1.0f, 0.0f);
//             glBegin(GL_TRIANGLES);
//             glColor3f(1.0f, 0.0f, 0.0f); glVertex3f(-1.0f, -1.0f, 0.0f);
//             glColor3f(0.0f, 1.0f, 0.0f); glVertex3f(1.0f, -1.0f, 0.0f);
//             glColor3f(0.0f, 0.0f, 1.0f); glVertex3f(0.0f, 1.0f, 0.0f);
//             glEnd();

//             angle += 0.5f; // Increment the angle for rotation

//             glfwSwapBuffers(window);
//             glfwPollEvents();
//         }
//     }

//     private void cleanup() {
//         glfwDestroyWindow(window);
//         glfwTerminate();
//     }

//     public static void main(String[] args) {
//         new RotatingTriangle().run();
//     }
// }