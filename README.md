# Project Task Scheduler (ASP.NET MVC)

## Overview

Project Task Scheduler is an academic ASP.NET MVC application focused on managing projects, their assigned tasks, and responsible members. The system emphasizes relational data modeling, MVC architecture, and structured navigation between related entities using the Code First approach.

---

## Objectives

* Apply ASP.NET MVC architectural principles
* Model relational data using Code First and Fluent API
* Implement full CRUD operations for projects
* Manage and track tasks within projects
* Establish clear navigation between projects, tasks, and members

---

## Technologies Used

* **Language:** C#
* **Framework:** ASP.NET Core MVC
* **ORM:** Entity Framework Core (Code First)
* **Database:** SQL Server
* **Frontend:** Razor Views, HTML, CSS
* **Tools:** Visual Studio, Git, GitHub

---

## System Architecture

The project follows the MVC (Model–View–Controller) pattern:

* **Models:** Represent domain entities (Project, Task, Member)
* **ViewModels:** Shape data for presentation purposes
* **Controllers:** Handle request flow and data manipulation
* **Views:** Render UI and manage user interaction

Entity relationships are defined using **Fluent API**, while **Data Annotations** are applied for validation.

---

## Core Features

### Project Management

* Create new projects
* Edit existing projects
* View detailed project information
* Delete projects

### Task Management

* Display tasks assigned to each project
* Edit task details
* Assign responsible members to tasks
* Navigate from tasks to assigned member details
  *(Task creation is handled implicitly and not exposed as a standalone create operation.)*

### Member Management

* View member details
* Display all tasks assigned to a specific member
* Navigate between members and related tasks

---

## Database Design

* **Project → Tasks:** One-to-Many relationship
* **Task → Member:** Many-to-One relationship

Relationships are configured using **Fluent API** to ensure clear data integrity and maintainability.

---

## Validation & Data Integrity

* Validation rules implemented using Data Annotations
* Required fields and relational constraints enforced

---

## Learning Outcomes

* Practical understanding of MVC architecture
* Experience with Code First and Fluent API
* Managing relational data in real-world applications
* Designing structured navigation between connected entities
* Improving data integrity and validation

---
