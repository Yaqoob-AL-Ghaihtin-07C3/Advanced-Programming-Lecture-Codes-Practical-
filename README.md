# Advanced-Programming-Lecture-Codes-Practical-

# Advanced Programming in C# - Lecture Codes (Practical)

This repository contains the practical code examples from the Advanced Programming in C# course lectures. The codes are organized into folders based on the lecture number.


---
## ترخيص محاضرات البرمجة الكائنية – C#

هذا المستند يوضح بيانات ترخيص محاضرات مقرر **البرمجة الكائنية (OOP) بلغة #C** الخاصة بالأستاذ **عيسى الجماعي**، والتي تم إعدادها واستخدامها لأغراض تعليمية ضمن جامعة إب.

---
---

# أكواد محاضرات البرمجة المتقدمة بلغة #C (عملي)

يحتوي هذا المستودع على الأمثلة البرمجية العملية من محاضرات مساق البرمجة المتقدمة باستخدام لغة #C. تم تنظيم الأكواد في مجلدات بناءً على رقم المحاضرة.

---

## Lecture 1: OOP Concepts & Introduction to Windows Forms

This lecture covers fundamental Object-Oriented Programming (OOP) principles and provides an introduction to building graphical user interfaces with Windows Forms.

### Code Files:

| #   | File Name                      | Description                                                                                             |
| --- | ------------------------------ | ------------------------------------------------------------------------------------------------------- |
| 1   | `OOP_Review.cs`                | Demonstrates basic OOP concepts like classes (`Person`), inheritance (`Student`, `Teacher`), and polymorphism. |
| 2   | `Abstract_Interfaces.cs`       | Shows how to use abstract classes (`Shape`) and interfaces (`IResizable`) to define contracts for classes.  |
| 3   | `Simple_MessageBox.cs`         | A minimal Windows Forms application that displays a "Hello, World!" message box.                          |
| 4   | `Form_ShowDialog.cs`           | Creates and displays a basic, empty form as a modal dialog using `ShowDialog()`.                          |
| 5   | `Main_Form_Application_Run.cs` | Shows the standard way to run a Windows Forms application using `Application.Run()`.                      |
| 6   | `Custom_Form_Text.cs`          | An example of customizing a form by changing its title text.                                              |
| 7   | `Custom_Form_Class.cs`         | Demonstrates creating a custom form by inheriting from the `Form` class.                                  |
| 8   | `Form_With_Button.cs`          | Adds a `Button` to the form and handles its `Click` event to show a message box.                          |

---

## المحاضرة الأولى: مفاهيم البرمجة الشيئية ومقدمة إلى Windows Forms

تغطي هذه المحاضرة المبادئ الأساسية للبرمجة الشيئية (OOP) وتقدم مقدمة لبناء واجهات المستخدم الرسومية باستخدام Windows Forms.

### ملفات الأكواد:

| #   | اسم الملف                    | الوصف                                                                                                   |
| --- | ------------------------------ | ------------------------------------------------------------------------------------------------------ |
| 1   | `OOP_Review.cs`                | يوضح مفاهيم البرمجة الشيئية الأساسية مثل الأصناف (`Person`)، الوراثة (`Student`, `Teacher`)، وتعدد الأشكال. |
| 2   | `Abstract_Interfaces.cs`       | يشرح كيفية استخدام الأصناف المجردة (`Shape`) والواجهات (`IResizable`) لتعريف العقود للأصناف الأخرى.         |
| 3   | `Simple_MessageBox.cs`         | تطبيق Windows Forms بسيط يعرض صندوق رسالة "Hello, World!".                                              |
| 4   | `Form_ShowDialog.cs`           | ينشئ ويعرض نافذة فارغة أساسية كنافذة حوار مشروطة باستخدام `ShowDialog()`.                                  |
| 5   | `Main_Form_Application_Run.cs` | يوضح الطريقة القياسية لتشغيل تطبيق Windows Forms باستخدام `Application.Run()`.                           |
| 6   | `Custom_Form_Text.cs`          | مثال على تخصيص نافذة عن طريق تغيير نص العنوان الخاص بها.                                                  |
| 7   | `Custom_Form_Class.cs`         | يوضح كيفية إنشاء نافذة مخصصة عن طريق الوراثة من الصنف `Form`.                                             |
| 8   | `Form_With_Button.cs`          | يضيف زرًا (`Button`) إلى النافذة ويتعامل مع حدث النقر (`Click`) الخاص به لعرض صندوق رسالة.                 |

---

## Lecture 2: Delegates, Events, and Generics

This lecture dives into powerful C# features like delegates, events for creating interactive applications, and generics for writing flexible, reusable code.

### Code Files:

| #   | File Name                  | Description                                                                                                |
| --- | -------------------------- | ---------------------------------------------------------------------------------------------------------- |
| 1   | `SimpleDelegate.cs`        | Introduces the concept of delegates by defining one and using it to call a method.                         |
| 2   | `UI_Elements.cs`           | Shows how to programmatically create and add UI controls like `TextBox` and `Button` to a form.              |
| 3   | `Event_Handlers.cs`        | Demonstrates how to handle UI events (like a button click) using lambda expressions.                       |
| 4   | `Custom_Events.cs`         | Explains how to define and use custom events within a class to enable a publisher-subscriber pattern.      |
| 5   | `Generic_Delegates.cs`     | Shows the use of generic delegates (`Func<T>`) to create delegates that can work with any data type.         |
| 6   | `Generic_Classes.cs`       | Introduces generic classes, which allow defining a class that is type-safe and reusable with different types. |
| 7   | `All_Concepts_Combined.cs` | A comprehensive example that combines delegates, events, generics, and UI elements into a single application. |

---

## المحاضرة الثانية: المفوضات، الأحداث، والأنواع العامة (Generics)

تتعمق هذه المحاضرة في ميزات #C القوية مثل المفوضات (delegates)، والأحداث (events) لإنشاء تطبيقات تفاعلية، والأنواع العامة (generics) لكتابة أكواد مرنة وقابلة لإعادة الاستخدام.

### ملفات الأكواد:

| #   | اسم الملف                  | الوصف                                                                                                     |
| --- | -------------------------- | ---------------------------------------------------------------------------------------------------------- |
| 1   | `SimpleDelegate.cs`        | يقدم مفهوم المفوضات (delegates) عن طريق تعريف واحد واستخدامه لاستدعاء دالة.                                  |
| 2   | `UI_Elements.cs`           | يوضح كيفية إنشاء وإضافة عناصر واجهة المستخدم برمجياً مثل `TextBox` و `Button` إلى النافذة.                    |
| 3   | `Event_Handlers.cs`        | يشرح كيفية التعامل مع أحداث واجهة المستخدم (مثل النقر على زر) باستخدام تعابير لامدا.                        |
| 4   | `Custom_Events.cs`         | يوضح كيفية تعريف واستخدام الأحداث المخصصة داخل صنف لتمكين نمط الناشر-المشترك.                                |
| 5   | `Generic_Delegates.cs`     | يعرض استخدام المفوضات العامة (`Func<T>`) لإنشاء مفوضات يمكنها العمل مع أي نوع بيانات.                        |
| 6   | `Generic_Classes.cs`       | يقدم الأصناف العامة، التي تسمح بتعريف صنف آمن من حيث النوع وقابل لإعادة الاستخدام مع أنواع مختلفة.            |
| 7   | `All_Concepts_Combined.cs` | مثال شامل يجمع بين المفوضات، الأحداث، الأنواع العامة، وعناصر واجهة المستخدم في تطبيق واحد.                  |



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



## المحاضرة الثالثة : # مكونات تحكم مخصصة 

هذا المستودع يحتوي على مجموعة من أكواد مكونات التحكم المخصصة (Custom Controls) المكتوبة بلغة C# والمصممة للاستخدام فأكواد اد نات نات خدام تطبيقات Windows For

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


### How to Use

1.  Clone the repository to your local machine.
2.  Open the `.cs` files in a text editor or an IDE like Visual Studio.
3.  To compile and run the Windows Forms examples, you will need the .NET Framework and the C# compiler (`csc.exe`). You can compile from the command line, for example:
    ```sh
    csc /target:winexe YourFileName.cs
    ```
4.  Run the generated `.exe` file.


