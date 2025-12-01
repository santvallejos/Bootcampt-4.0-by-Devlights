import { data } from "@/app/api/db";

export default function ProductsList() {
    return(
        <div>
            {data.map((data) => (
                <ul key={data.id}>
                    {data.title}
                </ul>
            ))}
        </div>
    )
}