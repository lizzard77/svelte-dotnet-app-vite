import { defineConfig } from 'vite'
import { svelte } from '@sveltejs/vite-plugin-svelte'

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [svelte()],
    build: {
        outDir: "wwwroot",
        rollupOptions: {
            output: {
                assetFileNames: "assets/[name].[ext]",
                chunkFileNames: "assets/[name].[ext]",
                entryFileNames: "assets/[name].js",
            },
        },
        write: true
    },
    server: {
        proxy: {
          '/api': {
                target : 'https://localhost:7207', 
                secure: false
            }
        }
    }
})
