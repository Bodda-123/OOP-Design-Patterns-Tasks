# Factory Pattern - Task 1

**Student:** Abdulrahman Nabil Shehata Mohamed  
**ID:** 42310194

Add a fourth toy, **Train**, priced at **180 LE**, and select it using **case 4**.

Run from the repository root:

```sh
dotnet run --project Task1-FactoryPattern
```

Enter `4` for Train. The program creates two trains, runs the four production steps for each, and prints their price and the count (`1`, then `2`).

## Which classes changed?

- **Train:** new subclass implementing all five abstract Toy methods, with price 180.
- **ToyFactory:** added `case 4` to create a Train. The production steps remain the same.
- **Program:** updated only the menu text to include `4=Train`; creation and display logic remain the same.

## Which classes did not change?

**Toy, Car, Bike and Plane** require no changes to support Train.

**Pricing note:** Car's price is 150 LE in the supplied task. Bike = 100 LE and Plane = 200 LE are illustrative values because their original prices were unavailable.
