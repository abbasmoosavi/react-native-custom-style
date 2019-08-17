
import { NativeModules } from 'react-native';
export {default as Color} from './src/Color';
export {default as FontFamily} from './src/FontFamily';
export {default as FontSize} from './src/FontSize';
export {default as Integer} from './src/Integer';

const { RNReactNativeCustomStyle } = NativeModules;

export default RNReactNativeCustomStyle;
