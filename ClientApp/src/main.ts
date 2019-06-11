import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';

export function getApiUrl() {
  return (environment.apiEndpoint);
}

const providers = [{ provide: 'API_ENDPOINT', useFactory: getApiUrl, deps: [] }];

if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic(providers)
  .bootstrapModule(AppModule)
  .catch(err => console.error(err));
