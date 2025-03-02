# Truck Weight Tracking Application
<img src="https://github.com/user-attachments/assets/334154f4-fa41-475e-be96-e742c85eb136" width="500" />

This application is designed to manage and track truck weight records. It allows users to add, validate, and display truck weight records, ensuring all the necessary information is properly recorded, such as truck IDs, gross weights, tare weights, and dates. The application uses **C# with a WinForms interface**.

## Key Features

- **Add New Record:** Allows users to input truck weight details, including Record ID, Truck ID, date measured, gross weight, and tare weight.
- **Validate Input:** Ensures that the input data is valid. It checks if the Record ID is unique, if the weights are positive, and that the tare weight does not exceed the gross weight.
- **Display Records:** Displays all truck records in a readable format.
- **Filter Overweight Trucks:** Displays records where the truck's gross weight exceeds 65,000 kg.
- **Clear Input Fields:** Resets the input fields after adding a record.

## Getting Started

### 1. **Prerequisites:**
   - Visual Studio (or another C# development environment)

### 2. **Installation:**
   - Download the solution code.
   - Extract the solution to a folder.
   - Open the solution in Visual Studio (the `*.sln` file).

### 3. **Running the Application:**
   - Build the solution in Visual Studio.
   - Run the executable file from the `bin\Debug` or `bin\Release` folder.

## Usage

### 1. **Adding a New Record:**
   - Enter the Record ID, Truck ID, date measured, gross weight, and tare weight in the input fields.
   - Click the "Add" button to add the record.
   - If successful, a message will appear indicating that the record was added. If there are validation errors, they will be displayed.

### 2. **Displaying All Records:**
   - Click the "Show Records" button to display all the truck weight records in a rich text box.

### 3. **Displaying Overweight Trucks:**
   - Click the "Show Overweight Trucks" button to display records where the gross weight exceeds 65,000 kg.

### 4. **Clearing Input Fields:**
   - After adding a record, the input fields are automatically cleared for new entries.

### 5. **Exiting the Application:**
   - Click the "Exit" button to close the application.

## Validation Rules

- **Record ID:** Must be a valid integer and unique for each record.
- **Truck ID:** Must be a valid integer greater than zero.
- **Date Measured:** Must be a valid date and not in the future.
- **Gross Weight:** Must be a valid positive number.
- **Tare Weight:** Must be a valid positive number, and cannot exceed the gross weight.
