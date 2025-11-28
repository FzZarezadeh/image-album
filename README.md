![Image Album Viewer Icon](https://copilot.microsoft.com/th/id/BCO.0216652f-b9f5-4805-9689-e63611fa072f.png)

🖼️ Image Album Viewer

A Windows Forms application written in C# that allows users to browse through a set of eight images using navigation buttons and zoom functionality. This project demonstrates how to work with arrays, image controls, and reusable methods for dynamic UI positioning in desktop applications.

---

📦 Features

- Image Loading:
  - Loads 8 images (0.jpg through 7.jpg) from the application directory.
  - Displays the current image in a PictureBox with Zoom mode enabled.

- Navigation:
  - Next and Previous buttons allow users to cycle through the image array.
  - Index wraps around to create a continuous loop (from last back to first, and vice versa).

- Zoom Controls (with Methods):
  - Zoom In and Zoom Out buttons resize the image proportionally.
  - Dedicated methods (zoomIn, zoomOut) handle resizing logic.
  - A helper method (centerImage) ensures the image is always centered after resizing.

- UI Feedback:
  - A label displays the current image filename (e.g., 3.jpg).

---

🛠 Technologies Used

- Language: C#
- Framework: .NET Framework (Windows Forms)
- IDE: Visual Studio
- UI Components: PictureBox, Button, Label

---

🚀 How to Run

1. Clone or download the repository.
2. Place 8 images (1.jpg to 8.jpg) in the application directory.
3. Open the solution in Visual Studio.
4. Build and run the project.
5. Use the navigation and zoom buttons to interact with the image album.

---

📁 Project Structure

`
image-album/
├── Form1.cs              // Main form logic for image loading, navigation, and zoom methods
├── Form1.Designer.cs     // UI layout and control definitions
├── Program.cs            // Application entry point
├── 0.jpg ... 7.jpg       // Sample images used in the album
`

---

💡 Educational Value

This project helps you practice:

- Managing arrays with multiple images
- Writing and reusing methods for UI logic (zoomIn, zoomOut, centerImage)
- Handling button click events
- Resizing and centering controls dynamically
- Using PictureBoxSizeMode.Zoom for responsive image display
