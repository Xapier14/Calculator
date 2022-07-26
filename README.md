# Simple Calculator App

Written as a sample Cerulean UI app to demonstrate Grids, Panels, Label and Buttons.

## Requirements

- .NET 6.0
- Cerulean.CLI

## Getting Started

> **Warning**
> This section is subject to change once Cerulean UI 1.0 releases.

1. Clone the repository and the submodules.
   ```bash
   git clone https://github.com/Xapier14/Calculator.git --recurse-submodules
   ```
2. Change into the project directory and build the XMLs.
   ```bash
   cd Calculator
   crn build-xml
   ```
3. Build and run the .NET C# project
   ```bash
   dotnet run
   ```

## Layout Tree

- MainLayout (Layout)
  - ResponsiveGrid (Grid)
    - BaseGrid (Grid)
      - DisplayPanel (Panel)
        - DisplayLabel (Label)
      - ButtonGrid (Grid)
        - OperationsGrid (Grid)
          - ButtonAddition (Button)
          - ButtonSubtraction (Button)
          - ButtonMultiplication (Button)
          - ButtonDivision (Button)
        - Button9 (Button)
        - Button8 (Button)
        - Button7 (Button)
        - Button6 (Button)
        - Button5 (Button)
        - Button4 (Button)
        - Button3 (Button)
        - Button2 (Button)
        - Button1 (Button)
        - ButtonClear (Button)
        - Button0 (Button)
        - ButtonEval (Button)

> ResponsiveGrid has a fixed column[1] width of 512 and a fixed row[1] height of 512.

> BaseGrid has a fixed row[0] height of 64.
