BXSS
=========
Boltless Screenshot System
Inspired by BOSS, but contains additional features

Installation
=========
Extract into KSP root directory

Usage
=========
UI will display as soon as the plugin loads.

* Screenshot: Click to take screenshot
* +/-: Toggles showing the options
* Autohide UI: If selected, will attempt to hide UI when taking a screenshot
* Auto Interval: If selected, will taking screenshots at specified intervals
 * Screenshot button will now toggle on and off instead of taking a screenshot immediately
* Supersample: Set this to desired supersample amount
* Interval: Set this to the desired number of seconds between screenshots
* Set: Set values

Key Bindings
---------

* F11: Show/Hide BXSS window
* z: Take screenshot/Toggle taking screenshots in interval mode

These are configurable in `<KSPRoot>/PluginData/BXSS/config.xml`

Troubleshooting
=========
Setting supersample value too high can cause KSP to crash by running out of memory. There is nothing I can do about this. You can also run out of memory by taking screenshots too quickly. You may need to expiriment to find optimal values. I find supersamples above 2 or 3 to not be that useful anyway, but values above 10 seem to be risky.

If the UI is not autohiding properly, it may depend on some timing issues. Try setting `AutoHideUIDelayInMilliseconds` in `<KSPRoot>/PluginData/BXSS/config.xml` to a higher value. If you had to do this please let me know as I may be able to setup a way to automate this in a way that works for most people.

Additionally, setting supersample too high, and interval too low while taking interval shots may cause the game to become an unplayable slideshow even if it doesn't run out of memory. You may need to stop screenshots by using the keyboard shortcut.

Reporting Problems
=========
Problems can be reported at the [Github Issues](https://github.com/kaylynb/BXSS/issues) page for this project.
Please include `<KSPRoot>/KSP_DATA/output_log.txt` when submitting a problem.

Source
=========
Source code is available at the [Github Repository](github.com/kaylynb/BXSS).
Source for a particular release can be found in the [Tags](https://github.com/kaylynb/BXSS/tags) view of the repository.