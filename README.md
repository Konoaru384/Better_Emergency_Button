# Better Emergency Button
<p align="center">
  <img src="https://img.shields.io/github/downloads/Konoaru384/Better_Emergency_Button/total?color=blue&style=for-the-badge" alt="Downloads" />
  <img src="https://img.shields.io/badge/version-1.0.0-blue?style=for-the-badge" alt="Version" />
  <img src="https://img.shields.io/badge/Exiled-9.10.0--rc.1-yellow?style=for-the-badge" alt="Exiled" />
  <img src="https://img.shields.io/badge/Game_Version-14.2-red?style=for-the-badge" alt="SCP:SL" />
</p>

---

### Description

**Better Emergency Button** is a plugin for **SCP: Secret Laboratory** built with the **Exiled API**.  

Its main features now include:  
- **Restricting certain roles** from pressing the emergency button.  
- **Allowing multiple presses** of the emergency button with a **configurable delay** between each click.  
- Customizable **broadcast messages** to inform players when the button is disabled for their role.

This plugin is lightweight, easy to configure, and perfect for server owners who want **more control and flexibility** over the emergency button functionality.

> ⚠️ **Note:**  
> This plugin has **not yet been fully tested**, as the SCP:SL version that includes the emergency button feature has not been released publicly yet.  
> It will be tested and optimized as soon as the update becomes available.

---

### Configuration :

```yaml
is_enabled: true
debug: false

# The list of roles that are not allowed to press emergency buttons.
# You can use any RoleTypeId from the list below.
blacklisted_roles:
  - Scp173
  - Scp049
  - Scp106
  - Scp096
  - Scp939
  - Scp3114

# Message sent to the player when they try to use the button.
denied_broadcast_message: "<color=red>You are not authorized to use the emergency button!</color>"
denied_broadcast_duration: 5

# Time in seconds between each allowed press of the emergency button.
# Set to 0 for instant reuse.
button_cooldown: 4.0

# Optional message shown when the button is ready again.
ready_use_message: "<color=green>The emergency button is ready to use!</color>"
ready_use_duration: 5
```

---

### Available RoleTypeIds FOR THE CONFIGURATION FILE

Here is the **complete list of all available RoleTypeIds** you can use in the configuration file  
under the `blacklisted_roles` section:

```
None
Spectator
Scp173
ClassD
Scientist
Scp106
NtfSpecialist
NtfSergeant
NtfCaptain
NtfPrivate
FacilityGuard
ChaosConscript
ChaosRepressor
ChaosMarauder
ChaosRifleman
Scp049
Scp0492
Scp096
Scp939
Scp3114
Tutorial
Overwatch
```

---

### Requirements

- **Exiled 9.10.0-rc.1 or newer**  
- **SCP:SL v14.2+**
