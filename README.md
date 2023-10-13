# WPF MVVM Application 

The MVVM WPF application utilizes Entity Framework 6.2.0 for data access and DevExpress 22.1 dependencies for UI components. Application performs CRUD operations on a connected Microsoft SQL Server database named "Shop" which contains tables for Customers, Orders, and Employees.

## Table of Contents
1. [Introduction](#introduction)
2. [Setup and Configuration](#setup-and-configuration)
   - [Prerequisites](#prerequisites)
   - [Database Configuration](#database-configuration)
3. [Project Structure](#project-structure)
4. [Usage](#usage)
   - [Run the Application](#run-the-application)
   - [Perform CRUD Operations](#perform-crud-operations)
5. [Dependencies](#dependencies)
   - [Entity Framework 6.2.0](#entity-framework-620)
   - [DevExpress 22.1](#devexpress-221)

---

## Introduction

WPF application is designed using the MVVM architecture, providing a structured approach to building user interfaces. It utilizes Entity Framework 6.2.0 for efficient data access and management and integrates DevExpress 22.1 components for enhanced UI functionality.

Application's primary objective is to perform CRUD operations on a connected Microsoft SQL Server database named "Shop," containing tables for Customers, Orders, and Employees.

![1](https://github.com/jjwaldon/wpf-mvvm-app/assets/147337604/46d44a56-8d0c-47d7-9ee6-a0483d106c08)


## Setup and Configuration

### Prerequisites

Ensure you have the following prerequisites installed on your development machine:

- .NET Framework
- Visual Studio with WPF and .NET development tools
- Entity Framework 6.2.0
- DevExpress 22.1 dependencies

### Database Configuration

1. Set up a Microsoft SQL Server database from attached script "Shop.sql"
2. Update the connection string in the application to point to the "Shop" database.

## Project Structure

- **Model**: Contains the data model representing Customers, Orders, and Employees.
- **ViewModel**: Houses the view model for UI components.
- **Views**: Holds the XAML views for various application screens.

## Usage

### Run the Application

1. Open the solution in Visual Studio.
2. Build the solution to ensure all dependencies are resolved.
3. Set the startup project and run the application.

### Perform CRUD Operations

- Use the application interface to create, read, update, and delete records from the Customers, Orders, and Employees tables in the connected "Shop" database, you can additionally filter the data.

![2](https://github.com/jjwaldon/wpf-mvvm-app/assets/147337604/62029384-3569-4475-a1f0-1dbf2e3eb6c7)

![3](https://github.com/jjwaldon/wpf-mvvm-app/assets/147337604/f04cddfb-91c4-454d-8396-7f7900abb632)

![4](https://github.com/jjwaldon/wpf-mvvm-app/assets/147337604/504c6290-e818-4817-8c36-0ce84c0a2b7b)


## Dependencies

### Entity Framework 6.2.0
### DevExpress 22.1
