# WinForms Custom Potion Brewing System

## Overview

WinForms Custom Potion Brewing System is a desktop application developed in C# using Windows Forms and Entity Framework Core.

The system simulates a fantasy potion brewing environment where users can manage ingredients, create and maintain potion recipes, execute brewing operations, and analyse brewing activity through a dashboard.

The application follows a layered architecture using Models, Repositories, Services, and Forms to separate business logic from data access and presentation.

---

## Features

### Ingredient Management

Users can:

- Add new ingredients
- Edit existing ingredients
- Delete ingredients
- View current inventory stock levels

Validation prevents invalid or incomplete ingredient records from being saved.

---

### Recipe Management

Users can:

- Create potion recipes
- Edit potion recipes
- Delete potion recipes
- Add ingredients to recipes
- Remove ingredients from recipes
- View recipe ingredient requirements

Each recipe stores:

- Recipe Name
- Special Effect
- Brewing Duration
- Required Ingredients
- Required Quantities

---

### Brewing Engine

The brewing module simulates potion creation using an asynchronous, event-driven approach.

Features include:

- Recipe selection
- Inventory validation before brewing
- Real-time brewing progress
- Progress tracking using a ProgressBar
- Non-blocking UI execution using `System.Windows.Forms.Timer`
- Automatic ingredient consumption after successful brewing

If insufficient inventory exists, brewing is prevented.

---

### Dashboard and Analytics

The dashboard provides operational metrics including:

- Most Frequently Brewed Potions
- Most Heavily Consumed Ingredients
- Brewing Throughput within a selected date range

Users can select custom date ranges to calculate brewing throughput.

---

## Technologies Used

- C#
- .NET
- Windows Forms
- Entity Framework Core
- SQLite
- LINQ

---

## Architecture

The project follows a layered architecture.

### Models

Represent database entities and relationships.

### Repositories

Responsible for database access and persistence operations.

### Services

Contain business logic, validation, and application rules.

### Forms

Provide the graphical user interface and user interactions.


---

## Database Relationships

### Recipe

A recipe can contain multiple ingredients.

### Ingredient

An ingredient can be used in multiple recipes.

### RecipeIngredient

Acts as a junction entity between recipes and ingredients while storing ingredient quantity requirements.

### BrewedPotion

Stores brewing history and completed brewing records.

---

## Key Concepts Applied

- CRUD Operations
- Repository Pattern
- Service Layer Pattern
- Entity Framework Core Relationships
- Asynchronous Programming
- Event-Driven Programming
- Data Validation
- WinForms UI Development
- Non-Blocking Execution Using Timers
- Inventory Management Logic

---

## Author

**Luz Moreno Campos**

Software Development Program