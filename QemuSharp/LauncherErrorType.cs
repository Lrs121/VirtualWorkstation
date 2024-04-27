namespace QemuSharp;

public enum LauncherErrorType
{
    EmptyName,
    EmptyFirmwarePath,
    EmptyEfiNvRamPath,
    EmptyCustomFirmwarePath,
    EmptyCustomEfiSecureBootFirmwarePath,
    EmptyCustomEfiNvRamPath,
    EmptyCustomEfiSecureBootNvRamPath,
    EmptyCustomChipsetModel,
    EmptyCustomDisplayType,
    EmptyCustomAudioHostDeviceType,
    EmptyCustomProcessorModel,
    EmptyCustomTpmDeviceType,
    EmptyCustomTpmType,
    EmptyCustomUsbControllerVersion,
    EmptyCustomNetworkInterfaceType,
    EmptyCustomNetworkInterfaceCard,
    EmptyCustomGraphicsControllerCard,
    EmptyCustomAudioControllerCard,
    EmptyCustomDiskControllerModel,
    EmptyCustomDiskFormat,
    EmptyCustomDiskCacheMethod,
    EmptyCustomKeyboardModel,
    EmptyCustomMouseModel,
    EmptyDiskPath,
    EmptyQemuPath,
    EmptySwtpmPath,
    EmptyCustomQemuArgumentValue,
    EmptyCustomQemuArgumentParameterKey,
    EmptyCustomQemuArgumentParameterValue,

    InvalidName,
    InvalidCustomChipsetModel,
    InvalidCustomDisplayType,
    InvalidCustomAudioHostDeviceType,
    InvalidCustomProcessorModel,
    InvalidCustomTpmDeviceType,
    InvalidCustomTpmType,
    InvalidCustomUsbControllerVersion,
    InvalidCustomNetworkInterfaceType,
    InvalidCustomNetworkInterfaceCard,
    InvalidCustomGraphicsControllerCard,
    InvalidCustomAudioControllerCard,
    InvalidCustomDiskControllerModel,
    InvalidCustomDiskFormat,
    InvalidCustomDiskCacheMethod,
    InvalidCustomKeyboardModel,
    InvalidCustomMouseModel,
    InvalidCustomQemuArgumentValue,
    InvalidCustomQemuArgumentParameterKey,
    InvalidCustomQemuArgumentParameterValue,
    CustomFirmwareDoesNotExist,
    CustomEfiNvRamDoesNotExist,
    DiskDoesNotExist,
    QemuSystemDoesNotExist,
    SwtpmDoesNotExist,

    HardwareAccelerationUnavailable,
    AudioUnavailable,

    InvalidFirmwareTypeForArchitecture,
    InvalidChipsetModelForArchitecture,
    InvalidProcessorModelForArchitecture,
    InvalidAddedFeatureForArchitecture,
    InvalidRemovedFeatureForArchitecture,

    InvalidForcePciOptionForChipsetModel,

    InvalidAbsolutePointingOptionForMouse,

    UnsupportedDisplay,
    UnsupportedAudioHostDevice,

    NoUsbControllersForNetworkCard,
    NoUsbControllersForSoundCard,
    NoUsbControllersForDiskBus,
    NoUsbControllersForKeyboard,
    NoUsbControllersForMouse,

    InvalidUsbControllerForNetworkCard,
    InvalidUsbControllerForSoundCard,
    InvalidUsbControllerForDiskBus,
    InvalidUsbControllerForKeyboard,
    InvalidUsbControllerForMouse,

    InvalidVgaEmulationOptionForGraphicsCard,
    InvalidGraphicsAccelerationOptionForGraphicsCard,

    InvalidInputOptionForSoundCard,
    InvalidOutputOptionForSoundCard,
    InvalidInputOutputOptionsForSoundCard,

    UnusedDiskController,
    InvalidDiskControllerForDisk,

    NoSouthbridgeIdeAvailable,

    SouthbridgeIdeAllowedOnce,

    InvalidCdromOptionForDiskBus,
    InvalidRemovableOptionForDiskBus,

    TooManyDrivesForDiskBus
}