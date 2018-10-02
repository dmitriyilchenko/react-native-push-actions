
# react-native-react-native-push-actions

## Getting started

`$ npm install react-native-react-native-push-actions --save`

### Mostly automatic installation

`$ react-native link react-native-react-native-push-actions`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-react-native-push-actions` and add `RNReactNativePushActions.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativePushActions.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNReactNativePushActionsPackage;` to the imports at the top of the file
  - Add `new RNReactNativePushActionsPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-react-native-push-actions'
  	project(':react-native-react-native-push-actions').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-react-native-push-actions/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-react-native-push-actions')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNReactNativePushActions.sln` in `node_modules/react-native-react-native-push-actions/windows/RNReactNativePushActions.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using React.Native.Push.Actions.RNReactNativePushActions;` to the usings at the top of the file
  - Add `new RNReactNativePushActionsPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNReactNativePushActions from 'react-native-react-native-push-actions';

// TODO: What to do with the module?
RNReactNativePushActions;
```
  