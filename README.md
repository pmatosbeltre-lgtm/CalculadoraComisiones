# Calculadora de Comisiones de Ventas

## Descripción

Aplicación web desarrollada con **ASP.NET Core Razor Pages** que permite calcular la comisión mensual de vendedores de forma rápida y precisa, tomando en cuenta el país en el que operan, el monto de ventas realizadas y los descuentos aplicados.

El sistema fue diseñado para brindar transparencia en el cálculo de ingresos y mejorar la experiencia del usuario mediante una interfaz moderna y validaciones automáticas.

---

## Objetivo del Proyecto

Desarrollar una herramienta web funcional que permita a vendedores estimar su comisión según reglas de negocio definidas por país.

---

## Tecnologías Utilizadas

- ASP.NET Core Razor Pages
- C#
- HTML5
- CSS3
- Bootstrap
- Visual Studio 2022

---

## Arquitectura del Proyecto

El sistema está organizado en capas:

### Presentación
- `Pages/`
- `wwwroot/`

Encargada de la interfaz visual y la interacción con el usuario.

### Lógica de Negocio
- `Services/ComisionService.cs`

Contiene las reglas para calcular comisiones según cada país.

### Datos
- `Models/ComisionRequest.cs`

Define la estructura de los datos ingresados por el usuario.

---

## Funcionalidades

- Selección de país
- Ingreso de monto de ventas
- Ingreso de descuentos aplicados
- Cálculo automático de comisión
- Validaciones de campos vacíos
- Validación de valores negativos
- Validación de descuento mayor que ventas
- Diseño moderno y responsive

---

## Países Disponibles

- India
- Estados Unidos
- Reino Unido
- Alemania
- Brasil
- México
- República Dominicana

---

## Reglas de Comisión

| País | Comisión |
|------|----------|
| India | 10% |
| US | 15% |
| UK | 12% |
| Germany | 8% |
| Brazil | 5% |
| Mexico | 7% |
| República Dominicana | 9% |
