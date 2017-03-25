# Banished-BorderlessPatcher

This is an updated version of the patcher created by dot and posted here (http://shiningrocksoftware.com/forum/discussion/537/release-native-borderless-fullscreen-patch#Item_1)

# What do I need?

You'll need eiter the .net framework version 2 or higher for the dotnet2.0 executable, and atleast .net framework 4.5.2 for the dotnet4.5.2 executable.

# How to use?

Download the latest release and patch Runtime-steam-x32.dll if your computer is x86 and Runtime-steam-x64.dll if your computer is x64.
I think the gog files are named something different, Runtime-x32.dll and Runtime-x64.dll.

After applying this patch you can then use
- windowed borderless gaming( http://westechsolutions.net/sites/WindowedBorderlessGaming/ )
- borderless gaming( https://github.com/Codeusa/Borderless-Gaming )

to adjust the resolution.


# What was changed?

The value the orginal patcher looked for has changed.


For anyone curious the function to look for is ?AdjustDisplay@Device@Video@@QAEXXZ void __thiscall Video::Device::AdjustDisplay(Video::Device *this)

Look for the value being modified before being passed to SetWindowLongW