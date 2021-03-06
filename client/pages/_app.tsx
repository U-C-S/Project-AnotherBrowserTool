import type { AppProps } from "next/app";

function MyApp({ Component, pageProps }: AppProps) {
	return (
		<>
			<Component {...pageProps} />
			<style global jsx>{`
				body {
					margin: 0;
					padding: 0 80px;
				}
			`}</style>
		</>
	);
}

export default MyApp;
