import { CartItem } from "@/app/types";

interface CartProps {
    items: CartItem[];
    onUpdateQuantity: (id: number, delta: number) => void;
    onRemove: (id: number) => void;
}

export default function Cart({ items, onUpdateQuantity, onRemove }: CartProps) {
    const total = items.reduce((sum, item) => sum + item.price * item.quantity, 0);
    const totalItems = items.reduce((sum, item) => sum + item.quantity, 0);

    if (items.length === 0) {
        return (
            <div className="border rounded-lg p-6 bg-gray-50">
                <h2 className="text-2xl font-bold mb-4">Carrito</h2>
                <p className="text-gray-500">Tu carrito está vacío</p>
            </div>
        );
    }

    return (
        <div className="border rounded-lg p-6 bg-white sticky top-4">
            <h2 className="text-2xl font-bold mb-4">Carrito</h2>
            <div className="space-y-3 mb-4 max-h-96 overflow-y-auto">
                {items.map((item) => (
                    <div key={item.id} className="flex gap-3 border-b pb-3">
                        <div className="flex-1">
                            <h4 className="font-semibold text-sm">{item.title}</h4>
                            <p className="text-sm text-gray-600">${item.price}</p>
                        </div>
                        <div className="flex items-center gap-2">
                            <button
                                onClick={() => onUpdateQuantity(item.id, -1)}
                                className="w-7 h-7 border rounded hover:bg-gray-100"
                            >
                                -
                            </button>
                            <span className="w-8 text-center">{item.quantity}</span>
                            <button
                                onClick={() => onUpdateQuantity(item.id, 1)}
                                className="w-7 h-7 border rounded hover:bg-gray-100"
                            >
                                +
                            </button>
                            <button
                                onClick={() => onRemove(item.id)}
                                className="ml-2 text-red-600 hover:text-red-800"
                            >
                                ✕
                            </button>
                        </div>
                    </div>
                ))}
            </div>
            <div className="space-y-2 border-t pt-4">
                <div className="flex justify-between text-sm">
                    <span>Productos:</span>
                    <span>{totalItems}</span>
                </div>
                <div className="flex justify-between font-bold text-lg">
                    <span>Total:</span>
                    <span>${total.toFixed(2)}</span>
                </div>
            </div>
        </div>
    );
}
