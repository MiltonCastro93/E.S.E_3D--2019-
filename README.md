# 🕹️ E.S.E — Experimental Stealth Experience

> Proyecto académico y prototipo jugable desarrollado en **Unity 2019**, inspirado en las mecánicas de *Metal Gear Solid* y adaptado a una jugabilidad **point & click**.

---

## 🧠 Descripción general

**E.S.E** (Experimental Stealth Experience) es un **prototipo técnico** centrado en la exploración de mecánicas de sigilo desde una nueva perspectiva:  
la **jugabilidad clásica de espionaje táctico**, pero reinterpretada bajo un esquema de **point & click**.

El proyecto fue desarrollado con fines **académicos y personales**, explorando la relación entre control indirecto del jugador y detección por IA, así como el impacto de la perspectiva fija en el diseño del sigilo.

---

## ⚙️ Detalles técnicos

- 🧩 **Motor:** Unity 2019  
- 💻 **Lenguaje:** C#  
- 🎓 **Tipo de proyecto:** Académico / Prototipo jugable  
- 👤 **Desarrollador:** Milton Castro  
- 🎨 **Recursos visuales y animaciones:** Mixamo (libre licencia)  
- 🧱 **Plataforma:** Windows  
- 💾 **Control de versiones:** Git / GitHub  

---

## 🧰 Mecánicas principales

- 🖱️ **Point & Click Movement:**  
  El jugador se desplaza con clics del mouse en lugar del clásico control con teclado, lo que introduce una sensación estratégica y pausada dentro de un entorno de sigilo.

- 🎥 **Cámaras fijas al estilo clásico:**  
  Se utiliza una cámara estacionaria similar a *Metal Gear Solid*, que favorece la lectura del entorno y la planificación del movimiento.

- 👀 **Lógica de detección enemiga:**  
  Sistema de visión y alertas basado en raycasts y colisiones, simulando el comportamiento básico de guardias patrullando.

- 🧠 **Estados de IA:**  
  Los enemigos cuentan con estados básicos (patrulla, alerta, persecución), implementados con condicionales y triggers.

---

## 🖼️ Capturas del proyecto

_(Imágenes de libre licencia utilizadas con fines académicos)_

![Captura 1](Images/captura1.png)
![Captura 2](Images/captura2.png)
![Captura 3](Images/captura3.png)
![Captura 4](Images/captura4.png)

> _(Podés reemplazar los enlaces por las rutas reales o URLs de tus imágenes del repositorio.)_

---

## 🧩 Arquitectura general del proyecto

- **PlayerController.cs** → Control de movimiento point & click, detección de posición objetivo y desplazamiento con NavMesh.  
- **CameraManager.cs** → Sistema de cámaras fijas con cambio dinámico según zonas.  
- **EnemyAI.cs** → Gestión de comportamiento enemigo por estados, detección y respuesta.  
- **GameManager.cs** → Control general de lógica y flujo del prototipo.  

---

## 🎯 Propósito y aprendizaje

El desarrollo de **E.S.E** sirvió como un ejercicio de análisis y práctica en:
- Diseño de **sistemas de movimiento alternativo** (point & click).  
- **Integración de IA básica** con enfoque en el comportamiento reactivo.  
- **Gestión de cámaras fijas** dentro de espacios cerrados.  
- **Modularidad de scripts** y estructuración del flujo general de juego.

---

## 📜 Licencia

Este proyecto es de uso **académico y sin fines comerciales**.  
Todos los recursos visuales (modelos, animaciones, texturas) provienen de **Mixamo** y son de **libre licencia**.

---

## ✨ Cierre

> *“La mejor forma de aprender diseño de juegos es reconstruir lo que admirás y hacerlo funcionar de una nueva manera.”*  
> — Milton Castro
