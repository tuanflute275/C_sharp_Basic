import MasterLayout from "../components/layout/MasterLayout";
import Home from "../components/page/Home/Home";

export const AppRoute = [
    {
        path: "/",
        element: <MasterLayout child={<Home />} />
    }
]