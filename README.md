# Smart Cart Application

## Overview
Welcome to the Smart Cart Application for Hamdan Mall. This console application simulates a shopping experience where users can add and remove items from their cart, view the cart contents, and calculate the total cost of their purchases. The application features different stores such as a Grocery Store, Clothing Store, and Electronics Store.

## Project Components

### Program.cs
Main entry point of the application:
- Initializes the shopping experience.
- Provides a menu-driven interface for users to interact with different stores and manage their shopping cart.

### Product.cs
Represents individual items available for purchase:
- Properties include Name, Price, and Category (using ProductCategory enum).

### ShoppingCart.cs
Manages the items added by the user:
- Uses a collection (e.g., List) to store items in the cart.
- Provides methods to add, remove, view items in the cart, and calculate the total cost.
- Implements discounts or promotions for specific products or groups of products.

### GroceryStore.cs, ClothingStore.cs, ElectronicsStore.cs
Represent different shops in the mall:
- Each store class displays available products and allows users to select items to add to their shopping cart.

### ProductGenerator.cs
Generates random products with varying attributes:
- Includes methods to generate food, clothing, and electronics products randomly.

## Features
- **Shopping Cart Management**: Add, remove, and view items.
- **Store-specific Shopping**: Browse and add items from Grocery Store, Clothing Store, and Electronics Store.
- **Random Product Display**: Show random products from all categories.
- **Discounts and Promotions**: Apply discounts for specific products or groups of products.
- **Professional Invoice**: Generate a professional invoice upon checkout with the total cost and thank you message.

## Usage
1. Run the application.
2. Follow the on-screen prompts to:
   - Shop at different stores.
   - Add items to your cart.
   - View your cart contents.
   - Calculate the total cost.
   - Apply discounts if eligible.
   - Checkout and exit.

## Unit Tests
Unit tests are included in the `ShoppingCartApplicationTests` project to verify:
- Adding and removing items from the cart.
- Calculating the total cost including discounts.

## Conclusion
Smart Cart Application provides a realistic shopping experience within a console interface, allowing users to manage their shopping cart across multiple stores in Hamdan Mall. With features like dynamic product generation, discount application, and a professional invoice system, the application aims to simulate a seamless shopping experience. Enjoy exploring and shopping with Smart Cart Application!