export interface Product {
    id: number;
    category: string;
    title: string;
    description: string;
    price: number;
    image: string;
    stock: number;
}

export interface CartItem extends Product {
    quantity: number;
}
