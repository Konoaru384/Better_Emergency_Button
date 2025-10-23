# 🚨 EmergencyButtonRestrictor
![Downloads](https://img.shields.io/github/downloads/YourUsername/EmergencyButtonRestrictor/total?color=blue&style=for-the-badge)
![Version](https://img.shields.io/badge/version-1.0.0-blue?style=for-the-badge)
![Exiled](https://img.shields.io/badge/Exiled-9.10.0--rc.1-yellow?style=for-the-badge)
![SCP:SL](https://img.shields.io/badge/Game_Version-14.x-red?style=for-the-badge)

---

### 📜 Description

**EmergencyButtonRestrictor** is a plugin for **SCP: Secret Laboratory** built with the **Exiled API**.  
Its goal is to **recreate the old SCP:SL atmosphere**, when **human-type SCPs could be contained or locked away**,  
by **restricting certain roles from pressing emergency release buttons**.

This plugin is lightweight, easy to configure, and perfect for server owner WHO DONT WANT the new emergency button.

There is also a broadcast option to inform player that this option is disable for her role (fully customizable)...

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
```

---

### 🧩 Available RoleTypeIds

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
FilmMaker
CustomRole
```


### 🎯 Plugin Objective

The goal of this plugin is to **restore the immersive and tactical atmosphere** from older versions of SCP:SL,  
where **SCPs and humans could be contained, trapped, or strategically managed**.  

With **EmergencyButtonRestrictor**, server owners can:
- Prevent certain SCPs or humans from using emergency buttons.  
- Create more realistic containment scenarios.  
- Encourage coordination and old-school SCP gameplay.  

### 🛠️ Requirements

- **Exiled 9.10.0-rc.1 or newer**  
> ✨ *Recreating the golden era of SCP: Secret Laboratory.*
