# StudentRentalAndMushroomApp

A complete **C# Windows Forms (WinForms)** desktop application developed for the C# programming assignment. The application integrates an authenticated student portal, a multi-tier hourly Bicycle Rental Calculator (Problem 1), and an adaptive Mushroom Identification system using continuous elimination (Problem 2).

---

## Table of Contents

1. [Project Overview](#project-overview)
2. [Project Structure](#project-structure)
3. [Component Walkthrough](#component-walkthrough)
   - [1. Application Login Form](#1-application-login-form)
   - [2. Main Selection Form](#2-main-selection-form)
   - [3. Problem 1: Bicycle Rental Calculator](#3-problem-1-bicycle-rental-calculator)
   - [4. Problem 2: Mushroom Identification](#4-problem-2-mushroom-identification)
   - [5. Navigation and Logout Architecture](#5-navigation-and-logout-architecture)
4. [Demonstration Credentials](#demonstration-credentials)
5. [C# Programming Concepts Used](#c-programming-concepts-used)
6. [How to Run in Visual Studio](#how-to-run-in-visual-studio)
7. [How to Run from the Command Line (.NET CLI)](#how-to-run-from-the-command-line-net-cli)

---

## Project Overview

The application satisfies all instructions and constraints set forth in the assignment:
- **Graphical User Interface:** Built using Windows Forms with modern, clean UI styling.
- **Problem 1 (Bicycle Rental):** Implements multi-tier hourly calculations using loops and decision control structures (`for` loop with `if-else`). Validates all inputs (integers, ranges `0–23` and `1–24`, start < end, single-day duration) and provides an itemized breakdown.
- **Problem 2 (Mushroom Identification):** Adaptively asks at most 3 questions based on the 6 mushrooms and 4 botanical characteristics. Dynamically selects questions that best partition remaining candidates, immediately announces single matches, announces when multiple possibilities remain after 3 questions, and notifies when no mushroom matches.
- **Navigation:** Supports seamless transitions between forms, returning to the main menu without logging out, and logging out directly to the login screen.

---

## Project Structure

```
c:\Users\rulak\OneDrive\Desktop\.NET\Assignment\
│
├── StudentRentalAndMushroomApp.sln        # Visual Studio Solution File
├── StudentRentalAndMushroomApp.slnx       # Modern XML Solution File
├── README.md                             # Documentation & Run Instructions
│
└── StudentRentalAndMushroomApp\          # WinForms Project Directory
    ├── StudentRentalAndMushroomApp.csproj# C# Project File (WinForms)
    ├── Program.cs                        # Main entry point (STAThread)
    ├── Mushroom.cs                       # Mushroom & Question entity models
    │
    ├── LoginForm.cs                      # Application Login Form logic
    ├── LoginForm.Designer.cs             # Login Form GUI controls
    │
    ├── MainMenuForm.cs                   # Main Selection Form logic
    ├── MainMenuForm.Designer.cs          # Main Selection Form GUI controls
    │
    ├── BicycleRentalForm.cs              # Problem 1: Bicycle Rental logic
    ├── BicycleRentalForm.Designer.cs     # Bicycle Rental GUI controls
    │
    ├── MushroomIdForm.cs                 # Problem 2: Mushroom Identification logic
    └── MushroomIdForm.Designer.cs        # Mushroom Identification GUI controls
```

---

## Component Walkthrough

### 1. Application Login Form (`LoginForm.cs`)

- **Controls:**
  - `txtUsername`: Name or Email input.
  - `txtPassword`: Password textbox with masked characters (`PasswordChar = '●'`).
  - `btnLogin`: Primary submission button.
  - `btnClear`: Resets input fields.
  - `lblDemoCredentials`: On-screen reminder of valid demonstration credentials.
- **Validation:**
  - Ensures neither username nor password is empty or whitespace.
  - Checks credentials against demonstration values.
- **Action on Success:**
  - Displays a welcoming message.
  - Opens `MainMenuForm` and hides `LoginForm`.

### 2. Main Selection Form (`MainMenuForm.cs`)

- **Controls:**
  - Radio buttons (`rbBicycleRental` and `rbMushroomId`) to select or immediately open an option.
  - Dedicated action buttons: **Open Bicycle >>** and **Open Mushroom >>** for immediate access.

### 3. Problem 1: Bicycle Rental Calculator (`BicycleRentalForm.cs`)

- **Form Controls:**
  - `txtStartHour`: Starting hour input.
  - `txtEndHour`: Ending hour input.
  - `btnCalculate`: Computes the cost and generates the hourly breakdown.
  - `lblTotalCost`: Prominent formatted display of the total cost in Rwandan Francs (RWF).
  - `lblDuration`: Displays the total duration and time interval.
  - `lstBreakdown`: Detailed hour-by-hour ledger displaying each 1-hour interval and applicable rate.
  - `btnReturn`: Returns to `MainMenuForm` without logging out.
  - `btnLogout`: Logs out directly to `LoginForm`.
- **Validation Constraints:**
  1. Both inputs must be valid integers (`int.TryParse`).
  2. Starting hour must be between `0` and `23`.
  3. Ending hour must be between `1` and `24`.
  4. Starting hour must be strictly less than ending hour (`startHour < endHour`).
  5. Rental cannot span more than one day.
- **Hourly Rate Schedule:**
  | Time Range | Rate per Hour |
  |---|---|
  | `00:00 – 07:00` | 500 RWF |
  | `07:00 – 14:00` | 1,000 RWF |
  | `14:00 – 19:00` | 1,500 RWF |
  | `19:00 – 21:00` | 1,000 RWF |
  | `21:00 – 24:00` | 500 RWF |
- **Calculation Algorithm:**
  Uses a `for` loop from `startHour` to `endHour - 1`. For each hour $h$, decision control structures determine the appropriate tier, accumulate the cost, and log the itemized interval.

---

### 4. Problem 2: Mushroom Identification (`MushroomIdForm.cs`)

- **Botanical Reference Matrix:**
  | Mushroom | Gills | Grows in forest | Has a ring | Has a convex cup |
  |---|:---:|:---:|:---:|:---:|
  | **Agaric jaunissant** | Yes | No | Yes | Yes |
  | **Amanite tue-mouche** | Yes | Yes | Yes | Yes |
  | **Cèpe de Bordeaux** | No | Yes | No | No |
  | **Coprin chevelu** | Yes | No | Yes | No |
  | **Girolle** | Yes | Yes | No | No |
  | **Pied bleu** | Yes | Yes | No | Yes |

- **Identification Questions:**
  1. *Does your mushroom grow in a forest?*
  2. *Does your mushroom have gills?*
  3. *Does your mushroom have a ring?*
  4. *Does your mushroom have a convex cup?*

- **Adaptive Identification Algorithm:**
  1. **Dynamic Question Selection (`SelectAdaptiveQuestion`):**
     - Does not use a hardcoded question chain.
     - Evaluates all unasked questions against the currently remaining candidates.
     - Selects the question that most evenly partitions remaining candidates ($|Count_{Yes} - Count_{No}|$ is minimized).
     - Automatically skips uninformative questions (where all remaining candidates share the exact same answer).
  2. **Continuous Elimination (`ProcessAnswer`):**
     - Iterates through the candidate list using loops and preserves only mushrooms that match the user's YES/NO answer.
     - Live candidate list updates in `lstRemaining` so the student/evaluator can visually observe elimination in real time.
  3. **Immediate Identification:**
     - As soon as only 1 candidate remains, the program immediately halts question-asking and displays the identified mushroom and its full profile.
     - *Example:* Answering **NO** to *"Does your mushroom have gills?"* identifies **Cèpe de Bordeaux** immediately in just **1 question**!
  4. **3-Question Cap:**
     - Asking is strictly limited to at most 3 questions.
     - If multiple candidates remain after 3 questions (e.g. *Girolle* and *Pied bleu*), the application displays: *"The identification reached the maximum limit of 3 questions. Remaining possible mushrooms: Girolle, Pied bleu."*
  5. **No Match Handling:**
     - If the user provides a combination that matches 0 mushrooms, a clear message is shown: *"No mushroom in the botanical database matches this combination of answers."*
  6. **Restart Button (`btnRestart`):**
     - Easily test multiple mushrooms sequentially without reopening the form.

---

### 5. Navigation and Logout Architecture

- **LoginForm** $\rightarrow$ **MainMenuForm** $\rightarrow$ **BicycleRentalForm** / **MushroomIdForm**.
- Clicking **Return to Main Selection** from either problem form closes that problem form and redisplays the main menu.
- Clicking **Log Out** from any form cleanly returns the user to the initial login screen, clearing the password field.

---

## Demonstration Credentials

| Role | Username / Email | Password |
|---|---|---|
| **Student** | `username` (or `student`) | `password123` |

---

## C# Programming Concepts Used

- **Variables and Data Types:** `int`, `string`, `bool`, `List<Mushroom>`, `List<Question>`.
- **Arithmetic & Comparison Operators:** `+`, `-`, `*`, `<`, `>`, `<=`, `>=`, `==`, `!=`.
- **Decision Control Statements:** `if`, `else if`, `else`, `switch`.
- **Loops:** `for` loop (hourly billing calculation), `foreach` loop (candidate filtering, question evaluation).
- **Methods:** Modular helper methods (`ValidateInputs`, `CalculateRentalCost`, `SelectAdaptiveQuestion`, `ProcessAnswer`, `ResetLoginForm`).
- **Data Structures:** Generic collections (`List<T>`) for managing mushrooms, questions, and question history.
- **Input Validation & Exception Handling:** `int.TryParse` with bounds checking, `try...catch` blocks, and informative `MessageBox` alerts.

---

## How to Run in Visual Studio

1. Open **Visual Studio 2022** (or 2019/later).
2. Click **Open a project or solution**.
3. Browse to `c:\Users\rulak\OneDrive\Desktop\.NET\Assignment\` and select **`StudentRentalAndMushroomApp.sln`**.
4. In the top toolbar, ensure the build configuration is set to **Debug** or **Release** and **Any CPU**.
5. Press **F5** (or click the green **Start** / Run button).
6. The application will start at the **Login Form**.

---

## How to Run from the Command Line (.NET CLI)

Open PowerShell or Command Prompt in the assignment directory and run:

```powershell
cd StudentRentalAndMushroomApp
dotnet run
```

Or execute the compiled binary directly:

```powershell
& "c:\Users\rulak\OneDrive\Desktop\.NET\Assignment\StudentRentalAndMushroomApp\bin\Debug\net10.0-windows\StudentRentalAndMushroomApp.exe"
```

