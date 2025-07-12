import { Component } from '@angular/core';
import { top } from "./Components/PageTop/PageTop";
import { Slider } from "./Components/slider/slider";
import { About } from "./Components/about/about";
import { Facts } from "./Components/facts/facts";
import { Features } from "./Components/features/features";
import { Service } from "./Components/service/service";
import { Team } from "./Components/team/team";
import { Footer } from "./Components/footer/footer";

@Component({
  selector: 'app-root',
  imports: [top, Slider, About, Facts, Features, Service, Team, Footer],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'day01';
}
