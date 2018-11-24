# Athena

With the increased usage of PMDs and bicycles in Singapore, there is also an increase in the number of accidents involving PMD users and cyclists. Our VR product aims at reducing the number of such accidents. We first target PMD users and cyclists to reinforce them with the proper rules and usage of such devices. As a two-pronged approach, our product then aims to encourage pedestrians to empathize with PMD users and cyclists. Our final goal through this product is to foster mutual understanding between cyclists and non-cyclists so that both parties can use Singapore’s paths and roads in harmony. 

Video Demostration of Athena can be found at https://www.youtube.com/watch?v=VT2GK06nqeE&feature=youtu.be&hd=1

## Compiling Athena Source Code into .apk

Due to the constraints of Unity, Athena.apk is unable to be deployed on Andriod Pie, thus this section will guide you how to compile Athena source code into a .apk file. 

If you have latest Athena.apk, please skip to section [Deployment].

### Prerequisites

These are the software that has to be downloaded before installing the project

```
* [Unity 3D](https://unity3d.com/)
* [UnitySetup Android Support for Editor]
* [Java SE Development Kit 8](https://www.oracle.com)
* [Gradle](https://gradle.org/)
* [Andriod Studio] (https://developer.android.com/studio/?gclid=Cj0KCQiA28nfBRCDARIsANc5BFDfWNBJDJMIzOmrsqhrw0mU6xkX2eN25mRyNIyCKOCN46nZ0ZsmA8YaAqN6EALw_wcB)
```

### Installing Source Code Enviroment

Before starting this steps, we will have assumed that an andriod device has been created in Andriod Studio. 

If an andriod device has yet to be created, please refer to (https://developer.android.com/studio/run/managing-avds) for instructions.

```
1. Clone the project from git@github.com:subtlehints/unityVR.git or https://github.com/subtlehints/unityVR.git
```

```
2. Install Unity 3D from https://unity3d.com/
```

```
3. Import project into Unity 3D
```

### Building apk File with Unity 3D

```
1. Configure Project Build Settings to Andriod
	- [File] > [Build Settings]
	- Locate [Platform] Selections
	- Click [Andriod]
	- Click [Switch Platform]
	- Select the Intended Device to run on at [Run Device]
```

```
2. Edit Bundle Identifier 
	- [Edit] > [Preferences] (on Windows) or [Unity] > [Preferences] (on OSX)
	- Locate Opened Inspector Taskbar
	- [Other Settings] > [Identification]
	- Change Package Name to Desired Name with "org.Organization.ProjectName"
		-> For Example: "com.Team21.Athena" 
```

```
3. Return To Build Settings and Click [Build and Run]
```

```
4. Name and Select a Folder for the New apk File.
```


## Deployment

### Prerequisites

```
* [Athena.apk]
* [Andriod Phone] (>= Android 4.4 and Andriod 8.1 <=)
```


### Enabling APK Installtion 

```
1. Go to [Settings]
```

```
2. Locate and Turn On [Unknown Sources]
```

### Installation of .apk File

```
1. Connect Andriod Phone to PC using USB Cable 
```

```
2. Select [Touch for other USB Options] 
```

```
3. Select [Media device (MTP)]
```

```
4. Connect Andriod Phone to PC using USB Cable 
```

```
5. Right Click Athena.apk  
```

```
6. Click on [Send To ] and Select Desired Android Phone  
```

```
7. Locate and Open Andriod Phone File Manager or [Downloads]
```

```
8. Locate and Tap Athena.apk   
```

```
9. Tap [Install] and Wait for The Installation to be Done
```

```
Athena.apk has been successfully installed.   
```

## Authors

* **ICT 2201 Team 21**










