# Task: Data Binding in Windows Forms

## Goal:
Implement data binding in a Windows Forms application to showcase the power and simplicity of connecting UI elements to data sources.

## Prerequisites:
- Installed Visual Studio (any version supporting Windows Forms).
- Basic knowledge of C# programming.
- Familiarity with Windows Forms application development.

## Steps:

### 1. Create a New Windows Forms Project:

- Open Visual Studio.
- Create a new Windows Forms App (.NET Core) project.
- Name the project "DataBindingApp" and choose a suitable location.
- Click "Create" to generate the project.

### 2. Design the User Interface:

- Open the Form1.cs file in the designer.
- Add controls to the form that you want to bind to data (e.g., TextBoxes, Labels, DataGridView).

### 3. Create a Data Model:

- Define a simple data model class that represents the data you want to bind.
- Example:

  ```csharp
  public class Person
  {
      public string FirstName { get; set; }
      public string LastName { get; set; }
  }

### 4. Add a Binding Source:

- Drag a `BindingSource` component from the Toolbox onto the form.
- Set the `DataSource` property of the `BindingSource` to an instance of your data model class (e.g., `List<Person>`).

  ```csharp
  public partial class Form1 : Form
  {
      private BindingSource personBindingSource;
      private List<Person> people;

      public Form1()
      {
          InitializeComponent();
          
          // Initialize the data source (replace with your data retrieval logic).
          people = GetPeopleData();

          // Create a BindingSource and set its DataSource to the list of people.
          personBindingSource = new BindingSource();
          personBindingSource.DataSource = people;
      }

      private List<Person> GetPeopleData()
      {
          // Replace this method with your data retrieval logic.
          // For simplicity, a static list is used here.
          return new List<Person>
          {
              new Person { FirstName = "John", LastName = "Doe" },
              new Person { FirstName = "Jane", LastName = "Smith" },
              // Add more sample data as needed.
          };
      }
  }
### 5. Bind Controls to Data:

- Select a control (e.g., TextBox) and set its `DataBindings` property.
- Choose the property you want to bind (e.g., Text) and select the corresponding property from the `BindingSource`.

  ```csharp
  // Example: Bind a TextBox to the FirstName property.
  textBoxFirstName.DataBindings.Add("Text", personBindingSource, "FirstName");
### 6. Implement Two-Way Data Binding (Continued - Optional):

- Set the `DataBindings` property of a control to enable two-way data binding.
- Update the data in the control, and observe changes in the underlying data source.

  ```csharp
  // Example: Enable two-way data binding for a TextBox.
  textBoxLastName.DataBindings.Add("Text", personBindingSource, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
In this example, the DataSourceUpdateMode.OnPropertyChanged ensures that changes in the TextBox update the data source immediately when the property changes.
