import {platformBrowserDynamic} from "@angular/platform-browser-dynamic";
import { AppModule } from './app.module';
import { AuthService } from "./auth.service";
platformBrowserDynamic().bootstrapModule(AppModule);