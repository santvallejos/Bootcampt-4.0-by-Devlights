
export default function ApplicationLayaout({
    children,
}: Readonly <{
    children: React.ReactNode;
}>){
    return (
        <div className="">
            <h1>Layaout</h1>
            {children}
        </div>
    )
}