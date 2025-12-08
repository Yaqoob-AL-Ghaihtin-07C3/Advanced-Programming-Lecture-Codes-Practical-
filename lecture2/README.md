## Lecture 3: # المحاضرة الثالثة مكونات تحكم مخصصة (Custom Controls) لـ C# WinForms

هذا المستودع يحتوي على مجموعة من أكواد مكونات التحكم المخصصة (Custom Controls) المكتوبة بلغة C# والمصممة للاستخدام في تطبيقات Windows Form
s. تم استخراج هذه الأكواد من ملفات المحاضرات والتمارين المرفقة.

## قائمة الملفات

| اسم الملف | الوصف |
| :--- | :--- |
| `SmartPasswordTextBox.cs` | مكون `TextBox` مخصص يعرض قوة كلمة المرور (ضعيف/متوسط/قوي) ويحتوي على أيقونة لإظهار/إخفاء كلمة المرور. |
| `GradientButton.cs` | مكون `Button` مخصص بخلفية متدرجة الألوان (Gradient) لتصميم عصري. |
| `SwipeNumeric.cs` | مكون `TextBox` مخصص للقيم الرقمية، يتيح تغيير القيمة عن طريق السحب (Swipe) بدلاً من أزرار الزيادة/النقصان التقليدية. |
| `SearchTextBox.cs` | مكون `TextBox` مخصص مزود بخاصية الاقتراح التلقائي (Auto-Suggest) عبر قائمة منسدلة لعرض نتائج البحث الفورية. |
| `DividerLine.cs` | مكون تحكم بسيط لإنشاء خط فاصل (أفقي أو عمودي) لتنظيم الواجهة. |
| `OperationPanel.cs` | مكون `Panel` مخصص لتنفيذ العمليات الحسابية الأساسية (جمع، طرح، ضرب، قسمة) مع زر لتنفيذ العملية المحددة. |
| `PanelOperation.cs` | مكون `Panel` مخصص لتنفيذ العمليات الحسابية الأساسية باستخدام `ComboBox` لاختيار العملية، ويسمح بإدخال الأرقام فقط. |

---



## Lecture 3:  Custom Controls for C# WinForms

This repository contains a collection of custom control codes written in C# and designed for use in Windows Forms applications. These codes were extracted from the attached lecture and exercise files.

## File List

| File Name | Description |
| :--- | :--- |
| `SmartPasswordTextBox.cs` | A custom `TextBox` control that displays password strength (Weak/Medium/Strong) and includes an icon to show/hide the password. |
| `GradientButton.cs` | A custom `Button` control with a gradient background for a modern design. |
| `SwipeNumeric.cs` | A custom `TextBox` for numeric values, allowing the value to be changed by swiping instead of traditional up/down buttons. |
| `SearchTextBox.cs` | A custom `TextBox` control equipped with an Auto-Suggest feature via a dropdown list for displaying instant search results. |
| `DividerLine.cs` | A simple control component for creating a dividing line (horizontal or vertical) to organize the interface. |
| `OperationPanel.cs` | A custom `Panel` control for performing basic arithmetic operations (Sum, Sub, Mult, Div) with a button to execute the selected operation. |
| `PanelOperation.cs` | A custom `Panel` control for performing basic arithmetic operations using a `ComboBox` to select the operation, and only allows numeric input. |

---


### How to Use

1.  Clone the repository to your local machine.
2.  Open the `.cs` files in a text editor or an IDE like Visual Studio.
3.  To compile and run the Windows Forms examples, you will need the .NET Framework and the C# compiler (`csc.exe`). You can compile from the command line, for example:
    ```sh
    csc /target:winexe YourFileName.cs
    ```
4.  Run the generated `.exe` file.


