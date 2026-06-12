# 🧑‍💻 Learning Projects - C# / .NET Portfolio

A collection of small console-based projects built with C# and .NET 8 to practice programming fundamentals, object-oriented design, and problem-solving skills.

This repository is part of my learning journey toward becoming a software developer.

---

# 📦 Projects Overview

## 🎯 1. GuessGame
A simple number guessing game where the user tries to guess a randomly generated number between 1 and 100.

### Features:
- Random number generation
- Input validation
- Hint system (higher / lower)
- Attempt counter

---

## 🔐 2. LoginSystem
A basic authentication system that allows users to register and log in using in-memory storage.

### Features:
- User registration
- Login validation
- OOP structure (User, UserService)
- LINQ-based authentication check

---

## 🎓 3. Student Database
A console-based student management system that stores students and their subject scores.

### Features:
- Add student with multiple subject scores
- Automatic average calculation
- Categorized student performance:
  - Low (0–10)
  - Medium (10–15)
  - High (15–20)
- Colored console output for better readability
- Dictionary-based data storage

---

# 🧠 Technologies Used

- C#
- .NET 8
- Object-Oriented Programming (OOP)
- Data Structures (List, Dictionary)
- LINQ
- Console Applications

---

# 🏗️ Project Structure

Each project is organized in its own folder:
learning-projects/
│
├── GuessGame/
├── LoginSystem/
├── Students/

Each project contains:
- Program.cs (entry point)
- Supporting classes (if needed)
- .csproj file

---

# 🚀 How to Run

### Requirements:
- .NET SDK 8.0 or later

### Run any project:

```bash
cd GuessGame
dotnet run
```
or: 
```bash
cd LoginSystem
dotnet run
```
or:
```bash
cd Students
dotnet run
```

---

## 🎯 Learning Goals
This repository was created to practice:

- Problem solving with C#
- Object-Oriented Programming principles
- Clean code structure
- Working with collections (List, Dictionary)
- Basic software design thinking
- Console application development

---

## 🔧 Future Improvements
- Add database support (SQL / SQLite)
- Add unit tests
- Improve architecture (Service / Repository pattern)
- Add file persistence (JSON storage)
- Add UI (WPF or ASP.NET Core Web API)

--- 

## 📌 Notes
- These projects are learning-focused, not production-ready
- No external database is used (in-memory data only)
- Passwords in LoginSystem are not encrypted (basic implementation for learning purposes)
