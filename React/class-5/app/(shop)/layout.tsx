"use client";

import CartBadge from "@/components/CartBadge";

export default function ApplicationLayaout({
    children,
}: Readonly <{
    children: React.ReactNode;
}>){
    return (
        <div className="min-h-screen bg-gray-100">
            <header className="bg-white shadow-sm border-b">
                <div className="container mx-auto px-4 py-4">
                    <div className="flex justify-between items-center">
                        <div>
                            <h1 className="text-3xl font-bold text-gray-800">Music Store</h1>
                            <p className="text-sm text-gray-600">Instrumentos y equipos musicales</p>
                        </div>
                        <CartBadge />
                    </div>
                </div>
            </header>
            <main className="container mx-auto px-4 py-8">
                {children}
            </main>
        </div>
    )
}
