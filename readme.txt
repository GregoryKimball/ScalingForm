2016-03-29-Gregory Kimball

Hello,

This is ScalingForm an extension of the Form control for C# WinForms.  

ScalingForm adds a default behavior to the Form control to resize all of its child controls whenever the Form dimensions are resized or maximized.

Include a reference for SCALINGFORM.DLL and add "using ScalingFormNamespace;". 
Then change the main Form1 class to extend ScalingForm.

"public partial class Form1 : Form"
->
"public partial class Form1 : ScalingForm"


Thanks!