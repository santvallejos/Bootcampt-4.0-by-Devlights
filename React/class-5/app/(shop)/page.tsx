"use client";

export default function ShopPage() {
    return (
        <div className="text-center py-12">
            <h2 className="text-3xl font-bold mb-4">Bienvenido a Music Store</h2>
            <p className="text-gray-600 mb-6">Explora nuestra selección de instrumentos musicales</p>
            <a 
                href="/products" 
                className="inline-block bg-blue-600 text-white px-6 py-3 rounded-lg hover:bg-blue-700 transition-colors"
            >
                Ver Productos
            </a>
        </div>
    );
}
