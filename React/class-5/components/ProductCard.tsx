import { Product } from "@/app/types";
import Image from "next/image";

interface ProductCardProps {
    product: Product;
    onAdd: (product: Product) => void;
    quantityInCart?: number;
}

export default function ProductCard({ product, onAdd, quantityInCart = 0 }: ProductCardProps) {
    const isMaxStock = quantityInCart >= product.stock;
    
    return (
        <article className="border rounded-lg p-4 hover:shadow-lg transition-shadow">
            <div className="relative h-48 mb-3">
                <Image
                    src={product.image}
                    alt={product.title}
                    fill
                    className="object-cover rounded"
                />
            </div>
            <div className="space-y-2">
                <span className="text-xs text-gray-500">{product.category}</span>
                <h3 className="font-semibold text-lg">{product.title}</h3>
                <p className="text-sm text-gray-600 line-clamp-2">{product.description}</p>
                <div className="flex justify-between items-center pt-2">
                    <span className="text-xl font-bold">${product.price}</span>
                    <span className="text-xs text-gray-500">
                        Stock: {product.stock - quantityInCart}
                    </span>
                </div>
                <button
                    onClick={() => onAdd(product)}
                    className="w-full bg-blue-600 text-white py-2 rounded hover:bg-blue-700 transition-colors disabled:bg-gray-400 disabled:cursor-not-allowed"
                    disabled={isMaxStock || product.stock === 0}
                >
                    {product.stock === 0 ? 'Sin stock' : isMaxStock ? 'Stock máximo' : 'Agregar'}
                </button>
            </div>
        </article>
    );
}
