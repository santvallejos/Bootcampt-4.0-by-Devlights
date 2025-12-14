import { Product, CartItem } from "@/app/types";
import ProductCard from "./ProductCard";

interface ProductListProps {
    products: Product[];
    onAddToCart: (product: Product) => void;
    cart: CartItem[];
}

export default function ProductList({ products, onAddToCart, cart }: ProductListProps) {
    return (
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
            {products.map((product) => {
                const cartItem = cart.find(item => item.id === product.id);
                return (
                    <ProductCard
                        key={product.id}
                        product={product}
                        onAdd={onAddToCart}
                        quantityInCart={cartItem?.quantity || 0}
                    />
                );
            })}
        </div>
    );
}
