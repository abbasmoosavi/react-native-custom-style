
# react-native-react-native-custom-style

## Getting started

`$ npm install react-native-react-native-custom-style --save`

### Mostly automatic installation

`$ react-native link react-native-react-native-custom-style`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-react-native-custom-style` and add `RNReactNativeCustomStyle.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativeCustomStyle.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNReactNativeCustomStylePackage;` to the imports at the top of the file
  - Add `new RNReactNativeCustomStylePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-react-native-custom-style'
  	project(':react-native-react-native-custom-style').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-react-native-custom-style/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-react-native-custom-style')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNReactNativeCustomStyle.sln` in `node_modules/react-native-react-native-custom-style/windows/RNReactNativeCustomStyle.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using React.Native.Custom.Style.RNReactNativeCustomStyle;` to the usings at the top of the file
  - Add `new RNReactNativeCustomStylePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNReactNativeCustomStyle from 'react-native-react-native-custom-style';

// TODO: What to do with the module?
RNReactNativeCustomStyle;
```
  