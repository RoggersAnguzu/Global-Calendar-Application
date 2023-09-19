# Global_CalendarApplication

The Global Calendar Application is a C# Windows Forms project that demonstrates the use of different calendar systems and provides a function to convert numeric months to their corresponding names. This project serves as a practical example of globalization and localization concepts in software development.

## Overview

The Global Calendar Application showcases the following features:

- Displaying date-related information using various calendar systems.
- Converting numeric months to their corresponding names..
- Learning about different calendar systems, including the Gregorian, Hebrew, and Taiwan calendars..

- 
-# ScreenShots
- ![Calendera](https://github.com/RoggersAnguzu/Global_CalendarApplication/assets/141458053/ace04c54-3d9f-4b7b-b991-32d54e6350b9)


## Application Usage

1. **Gregorian Calendar**:

   - Click on the "Gregorian Calendar" button to display date-related information based on the Gregorian calendar.
   - The application will show the current year, month, day of the month, and day of the week using the Gregorian calendar.
   - The numeric month is also converted to its corresponding name (e.g., 1 is converted to "January").

2. **Hebrew Calendar**:

   - Click on the "Hebrew Calendar" button to explore date-related details using the Hebrew calendar.
   - The application will provide information about the current year, month, day of the month, and day of the week in the Hebrew calendar.
   - The numeric month is converted to its corresponding name using the `month_num_to_name` function.

3. **Taiwan Calendar**:

   - By clicking the "Taiwan Calendar" button, you can access date information based on the Taiwan calendar.
   - The application will display the current year, month, day of the month, and day of the week in the Taiwan calendar system.

## Code Highlights

The application source code (found in the provided C# file) includes event handlers for each calendar system button. The `month_num_to_name` function is used to convert numeric months to their corresponding names using a `switch` statement.

```csharp
int x;
int.TryParse(this.textBox2.Text, out x);
this.label4.Text = month_num_to_name(x);

## Dependencies
This project relies on the following dependencies:

## .NET Framework.
Windows Forms
Contributing
Contributions to this project are welcome. If you'd like to contribute, please follow the  Contributing Guidelines.

License.
This project is licensed under the MIT License. See the LICENSE file for details.
