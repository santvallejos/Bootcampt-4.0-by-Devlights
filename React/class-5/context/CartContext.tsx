"use client";

import { createContext, useState, ReactNode } from "react";
import { Product, CartItem } from "@/app/types";

interface CartContextType {
    cart: CartItem[];
    addToCart: (product: Product) => void;
    updateQuantity: (id: number, delta: number) => void;
    removeFromCart: (id: number) => void;
    clearCart: () => void;
}

export const CartContext = createContext<CartContextType | null>(null);

export function CartProvider({ children }: { children: ReactNode }) {
    const [cart, setCart] = useState<CartItem[]>([]);

    const addToCart = (product: Product) => {
        setCart(prevCart => {
            const existing = prevCart.find(item => item.id === product.id);
            
            if (existing) {
                if (existing.quantity >= product.stock) {
                    return prevCart;
                }
                return prevCart.map(item =>
                    item.id === product.id
                        ? { ...item, quantity: item.quantity + 1 }
                        : item
                );
            }
            
            return [...prevCart, { ...product, quantity: 1 }];
        });
    };

    const updateQuantity = (id: number, delta: number) => {
        setCart(prevCart => {
            const item = prevCart.find(item => item.id === id);
            if (!item) return prevCart;

            const newQuantity = item.quantity + delta;

            if (newQuantity <= 0) {
                return prevCart.filter(item => item.id !== id);
            }

            if (newQuantity > item.stock) {
                return prevCart;
            }

            return prevCart.map(item =>
                item.id === id
                    ? { ...item, quantity: newQuantity }
                    : item
            );
        });
    };

    const removeFromCart = (id: number) => {
        setCart(prevCart => prevCart.filter(item => item.id !== id));
    };

    const clearCart = () => {
        setCart([]);
    };

    return (
        <CartContext.Provider value={{ cart, addToCart, updateQuantity, removeFromCart, clearCart }}>
            {children}
        </CartContext.Provider>
    );
}
