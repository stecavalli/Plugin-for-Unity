# Plugin-for-Unity
How to create a plugin, for use in Unity, in Android Studio using the Java language.
<br>
This repository refers to the [Flashlight-Android](https://github.com/stecavalli/Flashlight-Android) repository found in my GitHub.
# Software used:
Android Studio Giraffe | 2022.3.1 Patch 3
<br>
Unity 2022.3.15f1
# Guide to creating and developing the app
Follow the directions to create the application in Android Studio that are given in the repository [Flashlight-Android](https://github.com/stecavalli/Flashlight-Android).
 <br>
 <br>
In order to create the Plugin you must first create a new module, follow the instructions below:
 <br>
Click on File --> New --> New Module, a window like the following will open:
 <br>
 <br>
<img src="newModule.png" alt="new module" width="800">
 <br>
 <br>
Select Android Library in the Templates and then choose the name your Plugin will have by modifying the Module Name field. Select Java as the language and then click Finish. When the Module has been created it will be necessary to create a new Java class by clicking with the right mouse button, as seen in the following image, and selecting New --> Java Class. Choose the name of the Java file, which in my case is <b>FlashlightPlugin.java</b>.
 <br>
 <br>
<img src="java_Class.png" alt="java class" width="800">
 <br>
 <br>
After creating the FlashlightPlugin.java file, copy and paste the code from the FlashlightPlugin.java file found in this repository. You will get something like this:
 <br>
 <br>
<img src="javaClassCode.png" alt="java class code" width="800">
 <br>
 <br>
Open terminal and type <b>./gradlew build</b>. 
 <br>
 <br>
<img src="terminal.png" alt="terminal" width="800">
 <br>
 <br>
The file mylibrary-release.aar will be created and you can find it in the build directory of the mylibrary Module. 
 <br>
Select Project at the top left by clicking on the Android icon and label:
 <br>
 <br>
<img src="projectDirectory.png" alt="project directory" width="800">
 <br>
 <br>
The mylibrary-release.aar file is located in the flashlight --> mylibrary --> outputs --> aar directory. See the following image:
 <br>
 <br>
<img src="mylibrary-release.aar.png" alt="mylibrary-release.aar" width="800">
 <br>
 <br>
