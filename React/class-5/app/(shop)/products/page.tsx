"use client";

import { useState, useEffect } from "react";
import { Product } from "@/app/types";
import ProductList from "@/components/ProductList";
import Cart from "@/components/Cart";
import { useCart } from "@/hooks/useCart";

export default function ProductsPage() {
    const [products, setProducts] = useState<Product[]>([]);
    const [loading, setLoading] = useState(true);
    const { cart, addToCart, updateQuantity, removeFromCart } = useCart();

    useEffect(() => {
        const fetchProducts = async () => {
            try {
                setLoading(true);
                const response = await fetch('https://fakestoreapi.com/products');
                const data = await response.json();
                
                const mappedProducts: Product[] = data.map((item: any) => ({
                    id: item.id,
                    category: item.category,
                    title: item.title,
                    description: item.description,
                    price: item.price,
                    image: item.image,
                    stock: Math.floor(Math.random() * 20) + 5
                }));
                
                setProducts(mappedProducts);
            } catch (error) {
                console.error('Error al cargar productos:', error);
            } finally {
                setLoading(false);
            }
        };

        fetchProducts();
    }, []);

    if (loading) {
        return (
            <div className="flex justify-center items-center min-h-screen">
                <div className="text-center">
                    <div className="animate-spin rounded-full h-16 w-16 border-b-2 border-blue-600 mx-auto mb-4"></div>
                    <p className="text-xl font-semibold text-gray-700">Cargando productos...</p>
                </div>
            </div>
        );
    }

    return (
        <div className="grid grid-cols-1 lg:grid-cols-3 gap-8">
            <div className="lg:col-span-2">
                <h2 className="text-2xl font-bold mb-6">Productos Disponibles</h2>
                <ProductList products={products} onAddToCart={addToCart} cart={cart} />
            </div>
            <div className="lg:col-span-1">
                <Cart
                    items={cart}
                    onUpdateQuantity={updateQuantity}
                    onRemove={removeFromCart}
                />
            </div>
        </div>
    );
}
