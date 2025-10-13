<script>
  import logo from './assets/svelte.png'
  import Counter from './lib/Counter.svelte'

  // top-level awaiter remains a promise; in Svelte 5 you can keep this
  // and use {#await ...} in markup. If you enable experimental.async,
  // you could also use await expressions in scripts.
  const awaiter = fetch('/api/counter')
    .then(res => res.json())
    .then(data => {
      console.log(data)
      return data
    })
    .catch(err => {
      console.log(err)
      return err
    });
</script>

<main>
  <img src={logo} alt="Svelte Logo" />
  <h1>Hello .NET8 world!</h1>

  <Counter />

  {#await awaiter}
    <progress></progress>
  {:then a} 
    {JSON.stringify(a)}
  {/await}

  <p>
    Visit <a href="https://svelte.dev">svelte.dev</a> to learn how to build Svelte
    apps.
  </p>

  <p>
    Check out <a href="https://github.com/sveltejs/kit#readme">SvelteKit</a> for
    the officially supported framework, also powered by Vite!
  </p>
</main>

<style>
  :root {
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen,
      Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
  }

  main {
    text-align: center;
    padding: 1em;
    margin: 0 auto;
  }

  img {
    height: 16rem;
    width: 16rem;
  }

  h1 {
    color: #ff3e00;
    text-transform: uppercase;
    font-size: 4rem;
    font-weight: 100;
    line-height: 1.1;
    margin: 2rem auto;
    max-width: 14rem;
  }

  p {
    max-width: 14rem;
    margin: 1rem auto;
    line-height: 1.35;
  }

  @media (min-width: 480px) {
    h1 {
      max-width: none;
    }

    p {
      max-width: none;
    }
  }
</style>
