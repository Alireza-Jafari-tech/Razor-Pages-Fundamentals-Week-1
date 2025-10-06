# 📚 Book Catalog (ASP.NET Core Razor Pages)

This is a beginner-friendly ASP.NET Core Razor Pages project built as part of my learning journey.
The project demonstrates form handling, data binding, and page handler methods (OnPost, OnGet) in Razor Pages — all in a single simple web page.

[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## 🚀 Features
- 🧍‍♂️ Form Input Handling — Accepts student name, email, and age

- ⚙️ Model Binding — Uses [BindProperty] to connect form fields with a StudentData model

- ✅ Validation — Built-in Razor Pages validation with error messages

- 🔄 Multiple Submit Actions — Two separate submit buttons (Save and Show) handled by OnPostSave and OnPostShow

- 💬 Dynamic Result Display — Displays student details after form submission using query parameters

- 🎨 Modern UI Styling — Clean form and result box with simple CSS

## 🛠️ Technologies
- ASP.NET Core 8.0
- Razor Pages
- C#
- HTML + CSS

- ## 📸 Snapshots / Screenshots
- Home
- <img width="1343" height="678" alt="project" src="https://github.com/user-attachments/assets/a3f2a475-a858-45f0-8f9d-fb6d74f7bd53" />

- - ## ⚙️ Installation & Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/Alireza-Jafari-tech/Razor-Pages-Fundamentals-Week-1.git
   cd Razor-Pages-Fundamentals-Week-1
   ```

2. Run the application:
```bash
dotnet run
```
Then open http://localhost:5198

📂 Project Structure
```pgsql
Razor-Pages-Fundamentals-Week-1/
│
├── Pages/
│   ├── Index.cshtml          # Main page with form and result display
│   └── Index.cshtml.cs       # PageModel with handlers (Save, Show)
│
├── Model/
│   └── StudentData.cs        # Model class with Name, Email, Age properties
│
├── wwwroot/
│   └── css, js, etc.         # Static assets (optional)
│
├── Program.cs
├── Startup.cs (if applicable)
└── Razor-Pages-Fundamentals-Week-1.csproj
```

---

🎯 Learning Goals

- Understand the basics of Razor Pages architecture
- Learn model binding and form validation
- Practice handling multiple form submissions
- Explore data passing between requests with query parameters


📚 Future Improvements

- Add database storage (EF Core)
- Implement better validation messages
- Add more fields and pages (e.g., list of students)

📝 License

This project is licensed under the MIT License. See the LICENSE
 file for details

🤝 Contributing

This project is for learning purposes, but feel free to fork and improve it. Suggestions and pull requests are welcome.
