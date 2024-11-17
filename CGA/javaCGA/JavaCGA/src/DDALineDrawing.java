// import javax.swing.*;
// import java.awt.*;

// public class DDALineDrawing extends JPanel {
//     private int x1, y1, x2, y2;

//     public DDALineDrawing(int x1, int y1, int x2, int y2) {
//         this.x1 = x1;
//         this.y1 = y1;
//         this.x2 = x2;
//         this.y2 = y2;
//     }

//     @Override
//     protected void paintComponent(Graphics g) {
//         super.paintComponent(g);
//         drawLineDDA(g, x1, y1, x2, y2);
//     }

//     private void drawLineDDA(Graphics g, int x1, int y1, int x2, int y2) {
//         int dx = x2 - x1;
//         int dy = y2 - y1;
//         int steps = Math.max(Math.abs(dx), Math.abs(dy));

//         float xIncrement = dx / (float) steps;
//         float yIncrement = dy / (float) steps;

//         float x = x1;
//         float y = y1;

//         for (int i = 0; i <= steps; i++) {
//             g.fillRect(Math.round(x), Math.round(y), 1, 1);
//             x += xIncrement;
//             y += yIncrement;
//         }
//     }

//     public static void main(String[] args) {
//         // Get user input for the coordinates
//         int x1 = Integer.parseInt(JOptionPane.showInputDialog("Enter x1:"));
//         int y1 = Integer.parseInt(JOptionPane.showInputDialog("Enter y1:"));
//         int x2 = Integer.parseInt(JOptionPane.showInputDialog("Enter x2:"));
//         int y2 = Integer.parseInt(JOptionPane.showInputDialog("Enter y2:"));

//         JFrame frame = new JFrame("DDA Line Drawing Algorithm");
//         frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
//         frame.setSize(600, 600);

//         DDALineDrawing linePanel = new DDALineDrawing(x1, y1, x2, y2);
//         frame.add(linePanel);
//         frame.setVisible(true);
//     }
// }