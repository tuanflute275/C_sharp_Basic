import { Route, Routes } from "react-router-dom";
import { AppRoute } from "./routes/AppRoute";

function App() {
  return (
    <Routes>
      {/* implementing route here */}
      {
        AppRoute.map((e, i) => {
          return (
            <Route key={i} path={e.path} element={e.element} />
          )
        })
      }
    </Routes>
  );
}

export default App;
