/**
 * plugins/index.ts
 *
 * Automatically included in `./src/main.ts`
 */

import { App } from 'vue'
import { loadFonts } from './webfontloader'

export function registerPlugins (app: App<Element>) {
  loadFonts()
}
