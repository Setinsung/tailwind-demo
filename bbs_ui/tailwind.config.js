/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./index.html",
    "./src/**/*.{vue,js,ts,jsx,tsx}",
  ],
  theme: {
    extend: {
      colors: {
        'primary': '#409EFF',
        'ccc': '#ccc',
        'eee': '#eee',
        '999': '#999',
        'honey-yellow': '#fbb957'
      },
    },
  },
  plugins: [],
}
