import type { NextPage } from "next";
import Head from "next/head";
import { Header, Footer } from "../components/";

const Home: NextPage = () => {
  return (
    <div>
      <Head>
        <title>Clink</title>
        <meta name="description" content="Generated by create next app" />
      </Head>
      <Header />
      <main>
        <h1>
          Welcome to <a href="https://nextjs.org">Next.js!</a>
        </h1>

        <div>
          <a href="https://nextjs.org/docs">
            <p>Find in-depth information about Next.js features and API.</p>
          </a>
        </div>
      </main>

      <Footer />
    </div>
  );
};

export default Home;
