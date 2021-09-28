import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CadastrarFilmeComponent } from "./components/cadastrar-filme/cadastrar-filme.component";
import { ListarFilmeComponent } from "./components/listar-filme/listar-filme.component";

const routes: Routes = [
    {
        path: "",
        component: ListarFilmeComponent,
    },
    {
        path: "filme/listar",
        component: ListarFilmeComponent,
    },
    {
        path: "filme/cadastrar",
        component: CadastrarFilmeComponent,
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
